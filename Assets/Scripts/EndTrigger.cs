
using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GameManager gameManager;

	void OnTriggerEnter(){
		//to use this, the Collider must have 'isTrigger' checked
		gameManager.CompleteLevel();
	}
}
