using UnityEngine;
using System.Collections;

public class handBehaviourScript : MonoBehaviour {

	float speed = 0.2f;	
	float jumpspeed = 5;
	void Update (){

		// moveX
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			Vector3 position = this.transform.position;
			position.x -= speed;
			this.transform.position = position;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			Vector3 position = this.transform.position;
			position.x += speed;
			this.transform.position = position;
		}

		// jump
		if(Input.GetKeyDown("space"))
		{
			Vector3 position = this.transform.position;
			position.y += jumpspeed;
			this.transform.position = position;
		}
 }
}