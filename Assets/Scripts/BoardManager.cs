using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BoardManager : MonoBehaviour {

	[Serializable]
	public class Stage
	{
		public int chapter;
		public int section;
		public Stage (int x, int y)
		{
			chapter = x;
			section = y;
		}
	}

	//Chapters Array
	public Chapter[] chapters;
	//Parent to all GameObjects
	private Transform boardHolder;
	//chapter - section
	private Stage stage;

	public void SetupScene(int chapter, int section)
	{
		Debug.Log ("--Board Loaded-- Chapter: " + chapter + " Section: " + section);
		stage = new Stage (chapter, section);
		BoardSetup ();
	}

	void BoardSetup ()
	{
		boardHolder = new GameObject ("Board").transform;
		Debug.Log (boardHolder.transform.position);

		SetupBackground ();
		SetupDescription ();
	}

	private void SetupBackground ()
	{
		GameObject toInstantiate = chapters[stage.chapter].bgImg[0];
		GameObject instance = Instantiate (toInstantiate, new Vector3 (0, 0, 0f), Quaternion.identity) as GameObject;
		instance.transform.SetParent (boardHolder);
		Debug.Log (instance.name + ": " + instance.transform.position);
	}

	private void SetupDescription ()
	{
		Text description = GameObject.Find ("description").GetComponent<Text> ();;
		description.text = chapters[stage.chapter].sections[stage.section].description;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
