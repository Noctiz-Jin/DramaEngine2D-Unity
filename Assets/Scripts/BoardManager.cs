using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {

	public GameObject[] chapters;

	public void SetupScene(int chapter, int section)
	{
		Debug.Log ("--Board Loaded-- Chapter: " + chapter + " Section: " + section);
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
