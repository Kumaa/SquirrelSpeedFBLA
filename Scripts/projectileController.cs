using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileController : MonoBehaviour {

	public float speed;

	public PlayerControl player;


	public GameMaster gMaster;
	// Use this for initialization
	void Start () {

		gMaster = FindObjectOfType<GameMaster> ();
		//flip the projectile script
		player = FindObjectOfType<PlayerControl>();
		if (player.transform.localScale.x < 0) {
			speed = -speed;
			Vector3 theScale = transform.localScale;
			theScale.x *= -1;
			transform.localScale = theScale;
		}
		//end of flip projectile script
		Destroy (gameObject, 4f);

	}

	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);

	}

	void OnCollisionEnter2D(Collision2D enemy) {
		// put collision code here
		if (enemy.gameObject.tag == "Mutteor")
		{
			gMaster.points = gMaster.points + 100;
			Destroy (gameObject);
		}
	}
}
