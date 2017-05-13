using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MusicScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!(SceneManager.GetActiveScene ().Equals ("Celebrate")) && !(Input.GetKey(KeyCode.H))) {
			DontDestroyOnLoad (gameObject);
		}
	}
}
