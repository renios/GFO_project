using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_2 : MonoBehaviour {
	public int Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			if(Input.GetKey (KeyCode.Space)) {
			transform.Translate (Vector3.up * Speed *Time.deltaTime);
		}
		
	}
}
