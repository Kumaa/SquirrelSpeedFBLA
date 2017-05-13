using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class deathPage : MonoBehaviour {

	// Use this for initialization
	public GameMaster gMaster;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Return)) {
			gMaster.restarted = true;
			PlayerPrefs.DeleteKey ("NormalScore");
			SceneManager.LoadScene ("TestingStuff");
		}
	}
}
