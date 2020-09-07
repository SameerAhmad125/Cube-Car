using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevelWIN : MonoBehaviour {

	public void loadNextLevel()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

}
