using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mutteorScript : MonoBehaviour {

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
		Destroy (gameObject, 6);
	}

	void OnCollisionEnter2D(Collision2D other) {
		// put collision code here
		if (other.gameObject.tag == "Projectile")
		{
			GetComponent<AudioSource> ().Play();
			Destroy (gameObject.GetComponent<Rigidbody2D> ());
			Destroy (gameObject.GetComponent<PolygonCollider2D> ());
			enemyanimator.GetComponent<Animator> ().Play ("Death");
			Destroy (gameObject, 2.0f);
		}

		if (other.gameObject.tag == "Player")
		{
			enemyanimator.Play ("attackAnim");
			Debug.Log ("Grr!");

		}

	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.tag == "Player")
		{
			enemyanimator.Play ("attackAnim");
		}	
	}

}
