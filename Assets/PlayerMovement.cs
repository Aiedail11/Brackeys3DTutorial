using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce(0, 0, 200 * Time.deltaTime);
	}
}
