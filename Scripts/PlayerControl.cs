using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerControl : MonoBehaviour {
	public float maxSpeed = 0.5f;
	bool facingRight = true;
	public GameObject playerobject;

	private Animator playeranimator;

	/* GAME MANAGEMENT STUFF HERE */
	public GameObject themanager;

	public GameMaster gMaster;
	/* END OF GAME MANAGEMENT STUFF */

	//variables for shooting
	public Transform firePoint;
	public GameObject projectile;


	//interaction with enemies

	public bool isColliding = false;

	private bool invul = false;

	public bool dying = false;

	//variables involving the player's health

	public int playerLives = 4;

	public GameObject Live1;
	public GameObject Live2;
	public GameObject Live3;
	public GameObject Live4;


	void Start() {
		//squirrel = GetComponent<Rigidbody2D>();
		playeranimator = GetComponent<Animator>();


		//gMaster is the script referencing to the overall GameMaster object
		gMaster = themanager.GetComponent<GameMaster>();

	}

	void SetHighScore(){
		if (PlayerPrefs.GetInt ("highscore", 0) < gMaster.points) {
			PlayerPrefs.SetInt ("highscore", gMaster.points);
			PlayerPrefs.Save ();
		}
	}

	void Update() {
		Debug.Log (isColliding);

		if (playerLives == 3) {
			Destroy(Live4);
		}

		if (playerLives == 2) {
			Destroy (Live3);
		}

		if (playerLives == 1) {
			Destroy (Live2); 
		}

		if (playerLives == 0) {
			dying = true;
			Destroy (Live1);
			playeranimator.Play ("DeathAnim");
			Destroy (gameObject.GetComponent<Rigidbody2D>());
			Destroy (gameObject.GetComponent<CapsuleCollider2D>());
			Invoke ("endGame", 2.0f);


		}
	}

	void endGame() {
		Destroy (gameObject);
		SceneManager.LoadScene ("DeathScreen");
		gMaster.OnDeath ();
	}
	void FixedUpdate() {
		
			float move = Input.GetAxisRaw ("Horizontal");
		Vector2 pos = transform.position; 
		if (!dying) {
			if (Input.GetKey ("up") || Input.GetKey (KeyCode.W) || Input.GetKey ("down") || Input.GetKey (KeyCode.S) && !isColliding) {
				transform.Translate (new Vector3 (0, (Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime) / 2.5f, 0));
				playeranimator.Play ("Move");
			}

			if (Input.GetKey ("right") || Input.GetKey (KeyCode.D) || Input.GetKey ("left") || Input.GetKey (KeyCode.A) && !isColliding) {
				transform.Translate (new Vector3 ((Input.GetAxis ("Horizontal") * maxSpeed * Time.deltaTime) / 2.5f, 0, 0));
				playeranimator.Play ("Move");
			}
		}





		if (move > 0 && !facingRight) {
				Flip ();
		} else if (move < 0 && facingRight) {
				Flip ();
		}


		//SHOOTING CODE
		if (Input.GetKeyUp (KeyCode.Space)) {
			Instantiate (projectile, firePoint.position, firePoint.rotation);
			playeranimator.Play ("Shoot");
		}


	}


	void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}

	void OnCollisionEnter2D(Collision2D enemy) {
		// put collision code here

		if (!invul && enemy.gameObject.name == "Mutteor(Clone)")
		{
			playerLives--;
			resetVelocity ();
			GetComponent<Animator> ().Play ("getHit");
			StartCoroutine (Knockback (0.015f, 150, playerobject.transform.position));
			resetVelocity ();
			Invoke ("resetKinematicFalse", .5f);
			Invoke ("resetKinematicTrue", .1f);
			GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Dynamic;

			Debug.Log ("I'm the new hit");

		}


		if (!invul && enemy.gameObject.name == "Mutteor2(Clone)")
		{
			playerLives--;
			resetVelocity ();
			GetComponent<Animator> ().Play ("getHit");
			StartCoroutine (Knockback (0.015f, 150, playerobject.transform.position));
			resetVelocity ();
			Invoke ("resetKinematicFalse", 1.5f);
			Invoke ("resetKinematicTrue", .1f);
			GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Dynamic;

			Debug.Log ("I'm the new hit");

		}

	}

	void OnCollisionStay2D(Collision2D enemy) {
		if (enemy.gameObject.tag == "Mutteor") {
			isColliding = true;
		}
	}

	void OnCollisionExit2D(Collision2D enemy) {
		if (enemy.gameObject.tag == "Mutteor") {
			isColliding = false;
		}
	}


	/* HELPER FUNCTIONS */
	void resetVelocity() {
		GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		GetComponent<Rigidbody2D> ().velocity = Vector3.zero;



	}

	void resetKinematicFalse() {
		GetComponent<Rigidbody2D>().isKinematic = false;
		GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Static;
		float trytime = 0;
		while (trytime <= 1.5f) {
			trytime += Time.deltaTime;
		}
		if (trytime >= 1.5f) {
			GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Dynamic;
		}

	}

	void resetKinematicTrue() {
		GetComponent<Rigidbody2D>().isKinematic = true;
		GetComponent<Rigidbody2D> ().bodyType = RigidbodyType2D.Dynamic;


	}
	/* END OF HELPER FUNCTIONS */

	private IEnumerator InvulWait() {
		GetComponent<Animator> ().SetTrigger ("getHit");
		yield return new WaitForSeconds (2);
		invul = false;

	}


	public IEnumerator Knockback (float knockDur, float knockbackPwr, Vector3 knockbackDir) {
		float timer = 0;

		while (knockDur > timer) {
			timer += Time.deltaTime;
			GetComponent<Rigidbody2D> ().AddForce (new Vector3 (knockbackDir.x * -knockbackPwr, 0, transform.position.z));
		}
		resetVelocity ();


		//IEnumerator must yield 0 to finish the function
		yield return 0;
	}

	public IEnumerator Knockback2 (float knockDur, float knockbackPwr, Vector3 knockbackDir) {
		float timer = 0;

		while (knockDur > timer) {
			timer += Time.deltaTime;
			GetComponent<Rigidbody2D> ().AddForce (new Vector3 (knockbackDir.x, knockbackPwr, transform.position.z));
		}
		resetVelocity ();

		//IEnumerator must yield 0 to finish the function
		yield return 0;
	}

}
