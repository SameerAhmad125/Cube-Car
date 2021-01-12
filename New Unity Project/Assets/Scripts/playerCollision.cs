using UnityEngine;

public class playerCollision : MonoBehaviour {

	public Playermovement movement;

	void OnCollisionEnter (Collision collisionInfo)
	{
		if(collisionInfo.collider.tag == "obstacle")
		{
			movement.enabled = false ;
			FindObjectOfType<gameManager>().endGame();
		}
	}
}
