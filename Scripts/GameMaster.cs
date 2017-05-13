using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour {
	public int points;

	private int scoreTime;

	public Text scoreText;

	public Text pauseText;

	private IEnumerator coroutine;

	public bool restarted;

	public int pointsFromShooting;

	/* High Score Stuff Here */

	public LeaderBoard lBoard;

	/* High Score Stuff Up Here */

	// Use this for initialization

	void Awake() {
	}
	void Start () {

		if (restarted && PlayerPrefs.HasKey ("NormalScore")) {
			Debug.Log ("Hi!");
			PlayerPrefs.DeleteKey ("NormalScore");
			points = 0;
			restarted = false;
		} else {
			points = PlayerPrefs.GetInt ("NormalScore");
			Debug.Log ("Loading in " + points);
		}
		//scoreText.text = PlayerPrefs.GetInt ("NormalScore", 0).ToString ();
		//points = points +pointsFromShooting;

		pauseText.GetComponent<Text> ().enabled = false;

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.P)) {
			if (Time.timeScale == 1) {
				pauseText.GetComponent<Text> ().enabled = true;

				Time.timeScale = 0;

			} else {
				pauseText.GetComponent<Text> ().enabled = false;

				Time.timeScale = 1;
			}
		}

		if (Input.GetKeyDown (KeyCode.T)) {
			SceneManager.LoadScene ("LeaderBoard");
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit ();
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			restarted = true;
			SceneManager.LoadSceneAsync (SceneManager.GetActiveScene ().buildIndex);
		}

		if (Input.GetKeyDown (KeyCode.H)) {
			restarted = true;
			SceneManager.LoadScene ("StartScreen");
		}

		//FOR DEBUGGING PURPOSES ONLY!
		/*if (Input.GetKeyDown (KeyCode.C)) { 
			PlayerPrefs.DeleteAll();
			Debug.Log ("Cleared");
		}*/ 

		scoreText.text = points.ToString ();
		Debug.Log ("Current points = " + points);


	}

	public void OnDeath() {
		Debug.Log ("YOU CALLED?");
		lBoard.CheckForHighScore (points);
	}

	public void SaveScore() {
		PlayerPrefs.SetInt ("NormalScore", points);
		Debug.Log (points);
	}

	public void winLevel() {

	}


}
