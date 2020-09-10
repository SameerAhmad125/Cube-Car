using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class folloCube : MonoBehaviour {
	public Transform player;
	public Vector3 cameraPosition;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = player.position + cameraPosition;
	}
}
