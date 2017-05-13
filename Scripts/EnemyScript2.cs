using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript2 : MonoBehaviour {

	//spawnPoints
	public Transform spawnPoint1;
	public Transform spawnPoint2;
	public Transform spawnPoint3;
	public Transform spawnPoint4;
	public Transform spawnPoint5;
	public Transform spawnPoint6;
	public Transform spawnPoint7;
	public Transform spawnPoint8;


	//enemies
	public GameObject Mutteor;
	public GameObject Mutteor2;

	public float timerWave2;

	public GameMaster gMaster;



	/* Is it Spawned??? */
	bool s1 = false;
	bool s2 = false;
	bool s3 = false;
	bool s4 = false;
	bool s5 = false;
	bool s6 = false;
	bool s7 = false;
	bool s8 = false;
	bool s9 = false;
	bool s10 = false;
	bool s11 = false;
	bool s12 = false;
	bool s13 = false;
	bool s14 = false;
	bool s15 = false;
	bool s16 = false;
	bool s17 = false;
	bool s18 = false;
	bool s19 = false;
	bool s20 = false;
	bool checkpoint2 = false;
	/* Is it Spawned??? */


	// Use this for initialization
	void Start () {
		s1 = false;
		s2 = false;
		s3 = false;
		s4 = false;
		s5 = false;
		s6 = false;
		s7 = false;
		s8 = false;
		s9 = false;
		s10 = false;
		s11 = false;
		s12 = false;
		s13 = false;
		s14 = false;
		s15 = false;
		s16 = false;
		s17 = false;
		s18 = false;
		s19 = false;
		s20 = false;

		timerWave2 = 0;
	}

	// Update is called once per frame
	void Update () {

		if (checkpoint2 == true) {
			gMaster.SaveScore ();
			SceneManager.LoadScene ("Fact2");
		}

		timerWave2 += Time.deltaTime;
		//1
		if (timerWave2 >= 2 && !s1) {
			Instantiate (Mutteor, spawnPoint1.position, spawnPoint1.rotation);
			s1 = true;
		}
		//2
		if (timerWave2 >= 2.5 && !s2) {
			Instantiate (Mutteor, spawnPoint2.position, spawnPoint2.rotation);
			s2 = true;
		}
		//3
		if (timerWave2 >= 3 && !s3) {
			Instantiate (Mutteor, spawnPoint3.position, spawnPoint3.rotation);
			s3 = true;
		}
		//4
		if (timerWave2 >= 5 && !s4) {
			Instantiate (Mutteor, spawnPoint2.position, spawnPoint2.rotation);
			s4 = true;
		}
		//5
		if (timerWave2 >= 5 && !s5) {
			Instantiate (Mutteor, spawnPoint3.position, spawnPoint3.rotation);
			s5 = true;
		}
		//6
		if (timerWave2 >= 5.0 && !s6) {
			Instantiate (Mutteor2, spawnPoint6.position, spawnPoint6.rotation);
			s6 = true;
		}
		//7
		if (timerWave2 >= 5.0 && !s7) {
			Instantiate (Mutteor, spawnPoint7.position, spawnPoint7.rotation);
			s7 = true;
		}
		//8
		if (timerWave2 >= 5.0 && !s8) {
			Instantiate (Mutteor2, spawnPoint8.position, spawnPoint8.rotation);
			s8 = true;
		}
		//9
		if (timerWave2 >= 9 && !s9) {
			Instantiate (Mutteor, spawnPoint1.position, spawnPoint1.rotation);
			s9 = true;
		}
		//10
		if (timerWave2 >= 9.5 && !s10) {
			Instantiate (Mutteor, spawnPoint4.position, spawnPoint4.rotation);
			s10 = true;
		}
		//11
		if (timerWave2 >= 10 && !s11) {
			Instantiate (Mutteor2, spawnPoint6.position, spawnPoint6.rotation);
			s11 = true;
		}
		//12
		if (timerWave2 >= 13 && !s12) {
			Instantiate (Mutteor2, spawnPoint5.position, spawnPoint5.rotation);
			s12 = true;
		}
		//13
		if (timerWave2 >= 13.5 && !s13) {
			Instantiate (Mutteor2, spawnPoint6.position, spawnPoint6.rotation);
			s13 = true;
		}
		//14
		if (timerWave2 >= 14 && !s14) {
			Instantiate (Mutteor2, spawnPoint7.position, spawnPoint7.rotation);
			s14 = true;
		}
		//15
		if (timerWave2 >= 14.5 && !s15) {
			Instantiate (Mutteor2, spawnPoint8.position, spawnPoint8.rotation);
			s15 = true;
		}
		//16
		if (timerWave2 >= 18 && !s16) {
			Instantiate (Mutteor, spawnPoint1.position, spawnPoint1.rotation);
			s16 = true;
		}
		//17
		if (timerWave2 >= 18 && !s17) {
			Instantiate (Mutteor, spawnPoint2.position, spawnPoint2.rotation);
			s17 = true;
		}
		//18
		if (timerWave2 >= 20 && !s18) {
			Instantiate (Mutteor, spawnPoint3.position, spawnPoint3.rotation);
			s18 = true;
		}
		//19
		if (timerWave2 >= 20.5 && !s19) {
			Instantiate (Mutteor2, spawnPoint7.position, spawnPoint7.rotation);
			s19 = true;
		}
		//20
		if (timerWave2 >= 22 && !s20) {
			Instantiate (Mutteor2, spawnPoint5.position, spawnPoint5.rotation);
			s20 = true;
		}

		if (timerWave2 >= 27 && !checkpoint2) {
			checkpoint2 = true;
		}

	}
}
