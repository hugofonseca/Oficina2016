using UnityEngine;
using System.Collections;

public class handBehaviourScript : MonoBehaviour {

	float velocidade;	
	float animVelocidade;
	float flip = 0f;
	Rigidbody2D rb2d;
	Animator anim;

	bool ground = false;

	void Start()
	{
		anim = gameObject.GetComponent<Animator> ();
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
	}
	//float jumpspeed;
	bool isGrounded;
	void Update (){

		animVelocidade = Input.GetAxis ("Horizontal");
		// moveX
		if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 position = this.transform.position;
			position.x -= 0.3f;
			flip = 180f;
			this.transform.position = position;
		}
		if (Input.GetKey (KeyCode.RightArrow))
		    {
			Vector3 position = this.transform.position;
			position.x += 0.3f;
			flip = 0f;
			this.transform.position = position;

		}
		if(Input.GetKeyDown(KeyCode.UpArrow) && ground)
		{
			rb2d.AddForce(Vector2.up * 1350); // new vector2(0f, 1f);
		}

		anim.SetFloat ("velocidade", Mathf.Abs (animVelocidade));

		transform.rotation = Quaternion.Euler (new Vector3 (0f, flip, 0f));
		Debug.Log (velocidade);
	}
	

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag.Equals("ground"))
		{
			ground = true;
		}
	}
	void OnTriggerStay2D(Collider2D col)
	{
		if(col.gameObject.tag.Equals("ground"))
		{
			ground = true;
		}
		else if (col.gameObject.tag.Equals("enemy"))
		{
			ground = true;
		}

	}
	void OnTriggerExit2D(Collider2D col)
	{
		ground = false;
	}
}	
	
