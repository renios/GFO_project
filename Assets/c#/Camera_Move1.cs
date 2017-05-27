using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Move1 : MonoBehaviour {
	public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float playerXPos = Player.transform.position.x;
		transform.position = new Vector3(playerXPos, transform.position.y, transform.position.z);

		

		
	}
}
