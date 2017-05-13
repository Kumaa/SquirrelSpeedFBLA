using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mutteorScript2 : MonoBehaviour {

	//mutteor's speed
	public float speed;

	private Animator enemyanimator;


	// Use this for initialization

	void Start () {
		enemyanimator = GetComponent<Animator>();

	}

	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
		GetComponent<Rigidbody2D> ().velocity *= -1;
		Debug.Log ("Hi");
		Destroy (gameObject, 6.5f);
	}


	void OnCollisionEnter2D(Collision2D enemy) {
		// put collision code here
		if (enemy.gameObject.tag == "Projectile")
		{
			GetComponent<AudioSource> ().Play();
			Destroy (gameObject.GetComponent<Rigidbody2D> ());
			Destroy (gameObject.GetComponent<PolygonCollider2D> ());
			enemyanimator.GetComponent<Animator> ().Play ("Death");
			Destroy (gameObject, 2.0f);
		}
		if (enemy.gameObject.tag == "Player")
		{
			enemyanimator.Play ("attackAnim", 0, 2);
		}
	}
}
