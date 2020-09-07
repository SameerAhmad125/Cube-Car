using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {


	bool gameHasEnded = false;
	
	public float restartDelay = 2f;

	public GameObject completeLevelUI;

	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
	}

	public void endGame (){

		if(gameHasEnded == false){

		gameHasEnded = true;
		Invoke("Restart", restartDelay);
		}
	}

	void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
