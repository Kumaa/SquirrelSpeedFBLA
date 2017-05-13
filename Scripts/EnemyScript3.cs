using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyScript3 : MonoBehaviour {

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

	public GameMaster gMaster;

	public float timerWave3;


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
	bool s21 = false;
	bool s22 = false;
	bool s23 = false;
	bool s24 = false;
	bool s25 = false;
	bool checkpoint3 = false;
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
		s21 = false;
		s22 = false;
		s23 = false;
		s24 = false;
		s25 = false;

		timerWave3 = 0;
	}

	// Update is called once per frame
	void Update () {

		if (checkpoint3 == true) {
			gMaster.SaveScore ();
			SceneManager.LoadScene ("Fact3");
			gMaster.OnDeath ();
		}

		timerWave3 += Time.deltaTime;
		//1
		if (timerWave3 >= 2 && !s1) {
			Instantiate (Mutteor, spawnPoint1.position, spawnPoint1.rotation);
			s1 = true;
		}
		//2
		if (timerWave3 >= 2 && !s2) {
			Instantiate (Mutteor, spawnPoint4.position, spawnPoint4.rotation);
			s2 = true;
		}
		//3
		if (timerWave3 >= 2 && !s3) {
			Instantiate (Mutteor2, spawnPoint5.position, spawnPoint5.rotation);
			s3 = true;
		}
		//4
		if (timerWave3 >= 2 && !s4) {
			Instantiate (Mutteor2, spawnPoint8.position, spawnPoint8.rotation);
			s4 = true;
		}
		//5
		if (timerWave3 >= 2.7 && !s5) {
			Instantiate (Mutteor, spawnPoint2.position, spawnPoint2.rotation);
			s5 = true;
		}
		//6
		if (timerWave3 >= 2.7 && !s6) {
			Instantiate (Mutteor, spawnPoint3.position, spawnPoint3.rotation);
			s6 = true;
		}
		//7
		if (timerWave3 >= 2.7 && !s7) {
			Instantiate (Mutteor2, spawnPoint6.position, spawnPoint6.rotation);
			s7 = true;
		}
		//8
		if (timerWave3 >= 2.7 && !s8) {
			Instantiate (Mutteor2, spawnPoint7.position, spawnPoint7.rotation);
			s8 = true;
		}
		//9
		if (timerWave3 >= 7 && !s9) {
			Instantiate (Mutteor, spawnPoint1.position, spawnPoint1.rotation);
			s9 = true;
		}
		//10
		if (timerWave3 >= 7 && !s10) {
			Instantiate (Mutteor2, spawnPoint5.position, spawnPoint5.rotation);
			s10 = true;
		}
		//11
		if (timerWave3 >= 7.5 && !s11) {
			Instantiate (Mutteor2, spawnPoint6.position, spawnPoint6.rotation);
			s11 = true;
		}
		//12
		if (timerWave3 >= 7.5 && !s12) {
			Instantiate (Mutteor, spawnPoint2.position, spawnPoint2.rotation);
			s12 = true;
		}
		//13
		if (timerWave3 >= 9.5 && !s13) {
			Instantiate (Mutteor, spawnPoint3.position, spawnPoint3.rotation);
			s13 = true;
		}
		//14
		if (timerWave3 >= 9.5 && !s14) {
			Instantiate (Mutteor2, spawnPoint7.position, spawnPoint7.rotation);
			s14 = true;
		}
		//15
		if (timerWave3 >= 10 && !s15) {
			Instantiate (Mutteor, spawnPoint4.position, spawnPoint4.rotation);
			s15 = true;
		}
		//16
		if (timerWave3 >= 10 && !s16) {
			Instantiate (Mutteor2, spawnPoint8.position, spawnPoint8.rotation);
			s16 = true;
		}
		//17
		if (timerWave3 >= 13 && !s17) {
			Instantiate (Mutteor, spawnPoint3.position, spawnPoint3.rotation);
			s17 = true;
		}
		//18
		if (timerWave3 >= 14.5 && !s18) {
			Instantiate (Mutteor, spawnPoint3.position, spawnPoint3.rotation);
			s18 = true;
		}
		//19
		if (timerWave3 >= 15.5 && !s19) {
			Instantiate (Mutteor2, spawnPoint6.position, spawnPoint6.rotation);
			s19 = true;
		}
		//20
		if (timerWave3 >= 17 && !s20) {
			Instantiate (Mutteor2, spawnPoint6.position, spawnPoint6.rotation);
			s20 = true;
		}
		//21
		if (timerWave3 >= 20 && !s21) {
			Instantiate (Mutteor, spawnPoint3.position, spawnPoint3.rotation);
			s21 = true;
		}
		//22
		if (timerWave3 >= 20.5 && !s22) {
			Instantiate (Mutteor2, spawnPoint7.position, spawnPoint7.rotation);
			s22 = true;
		}
		//23
		if (timerWave3 >= 21.5 && !s23) {
			Instantiate (Mutteor, spawnPoint1.position, spawnPoint1.rotation);
			s23 = true;
		}
		//24
		if (timerWave3 >= 22.5 && !s24) {
			Instantiate (Mutteor2, spawnPoint6.position, spawnPoint6.rotation);
			s24 = true;
		}
		//25
		if (timerWave3 >= 23.5 && !s25) {
			Instantiate (Mutteor, spawnPoint2.position, spawnPoint2.rotation);
			s25 = true;
		}

		if (timerWave3 >= 30 && !checkpoint3) {
			checkpoint3 = true;
		}

	}
}
