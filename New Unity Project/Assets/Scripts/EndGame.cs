using UnityEngine;

public class EndGame : MonoBehaviour {

	public gameManager game;

	void OnTriggerEnter()
	{
		game.CompleteLevel();
	}
}
