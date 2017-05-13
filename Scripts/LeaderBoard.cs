using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class LeaderBoard : MonoBehaviour
{
	public Text[] highScores;

	int[] highScoreValues;
	void Start ()
	{
		

		highScoreValues = new int[highScores.Length];
		for (int i = 0; i < highScores.Length; i++)
		{
			highScoreValues [i] = PlayerPrefs.GetInt ("highScoreValues" + i);
		}
		DrawScores ();
	}

	void SaveScores() {
		for (int i = 0; i < highScores.Length; i++)
		{
			PlayerPrefs.SetInt ("highScoreValues" + i, highScoreValues[i]);
		}
	}

	public void CheckForHighScore(int value)
	{
		int newScore = value;
		int oldScore = 0;
		for (int i = 0; i < highScoreValues.Length; i++)
		{  
			if (value > highScoreValues [i]) {
				for (int j = highScoreValues.Length - 1; j > i; j--) {
					highScoreValues [j] = highScoreValues [j - 1];
				}
				highScoreValues [i] = value;
				break;
			}
		}
		SaveScores ();
	}

	void DrawScores()
	{

		for (int i = 0; i < highScores.Length; i++) {
			highScores [i].text = highScoreValues [i].ToString ();
		}
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.H)) {
			SceneManager.LoadScene ("StartScreen");
		}
	}
}
