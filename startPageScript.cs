using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startPageScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Return)) {
			SceneManager.LoadScene ("TestingStuff");
		}

		if (Input.GetKey (KeyCode.I)) {
			SceneManager.LoadScene ("Instructions");
		}

		if (Input.GetKey (KeyCode.S)) {
			SceneManager.LoadScene ("Story");
		}

		if (Input.GetKey (KeyCode.L)) {
			SceneManager.LoadScene ("LeaderBoard");
		}

	}
}
