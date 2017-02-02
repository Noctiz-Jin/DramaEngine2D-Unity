using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Entry point of the Game
public class Loader : MonoBehaviour {

	public GameObject gameManager;

	void Awake () {
		if (GameManager.instance == null)
			Instantiate (gameManager);
	}

	void Start () {
		
	}
}
