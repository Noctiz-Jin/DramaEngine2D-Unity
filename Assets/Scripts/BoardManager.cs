using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {

	//Chapters Array
	public GameObject[] chapters;
	//Parent to all GameObjects
	private Transform boardHolder;

	public void SetupScene(int chapter, int section)
	{
		Debug.Log ("--Board Loaded-- Chapter: " + chapter + " Section: " + section);
		BoardSetup ();
	}

	void BoardSetup ()
	{
		boardHolder = new GameObject ("Board").transform;
		Debug.Log (boardHolder.transform.position);
		GameObject toInstantiate = chapters [0];
		GameObject instance = Instantiate (toInstantiate, new Vector3 (0, 0, 0f), Quaternion.identity) as GameObject;

		instance.transform.SetParent (boardHolder);

		Debug.Log (instance.transform.position);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
