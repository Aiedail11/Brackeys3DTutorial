
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;

	void OnCollisionEnter(Collision collisionInfo)
	{
		if(collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;
			FindObjectOfType<GameManager>().EndGame(); 
			// We do this because Game Manager will not be automatically connected to the player object
			//We need to use FindObjectOfType if we introduce an object that does not exist at the start of the scene
		}
	}
}
