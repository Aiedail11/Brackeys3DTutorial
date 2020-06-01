
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
	public float restartDelay = 1f;
	public GameObject completeLevelUI;

	public void EndGame(){
		if(!gameHasEnded)
		{
		gameHasEnded = true;
		Debug.Log("Game Over");
		Invoke("Restart", restartDelay); 
		// instead of calling Restart right away, we use invoke to create
		// a time delay
		}
	}

	void Restart(){
		gameHasEnded = false;
		//reload current scene
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		//Note: Unity Does not have enough time to calculate lighting when loading
		// with SceneManager, so you may need to go to Lighting Settings 
		// and uncheck 'auto' at the bottom
		// 
	}

	public void CompleteLevel(){
		
		completeLevelUI.SetActive(true);
	}

}

