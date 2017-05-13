using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class instrScript : MonoBehaviour {
	//public GameMaster gMaster;

	// Use this for initialization
	void Start () {
		//gMaster = FindObjectOfType<GameMaster> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Escape)) {
			//gMaster.restarted = true;
			SceneManager.LoadScene ("StartScreen");
		}
	}
}
