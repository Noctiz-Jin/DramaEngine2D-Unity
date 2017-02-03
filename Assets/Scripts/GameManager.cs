using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// singleton self
	public static GameManager instance = null;
	// BoardManager instance
	public BoardManager boardManager;


	void Awake () {
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);
		DontDestroyOnLoad (gameObject);
		Debug.Log("--GameManager Loaded--");

		boardManager = GetComponent<BoardManager> ();

		boardManager.SetupScene (0, 0);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
