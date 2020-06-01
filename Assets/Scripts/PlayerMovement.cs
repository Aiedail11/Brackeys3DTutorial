using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// FixedUpdate is better for physics stuff, but is sometimes not responsive enough
	// for certain types of input, such as jumping
	void FixedUpdate(){
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if(Input.GetKey("d")){
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
			//adding the final (optional) parameter to AddForce makes the sideways
			//movement feel more responsive
		}
		if(Input.GetKey("a")){
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if(rb.position.y < -1f){
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
