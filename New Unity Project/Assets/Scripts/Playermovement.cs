using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playermovement : MonoBehaviour {
	public Rigidbody rb;

	public float forwardForce = 1000f;
	public float sidewaysForce = 500f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		
		if( Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)){
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
	
		if( Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)){
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}


		if(rb.position.y < -0f){
			FindObjectOfType<gameManager>().endGame();
		}

	}
}
