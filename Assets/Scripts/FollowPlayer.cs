
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform player;
	public Vector3 offset;

	// Update is called once per frame
	void Update () {
		transform.position = player.position + offset; //lowercase transform references the transform component of the current object
	
	}
}
