﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_1 : MonoBehaviour {
	public int Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector3.right * Speed *Time.deltaTime);
		}
			if(Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector3.left * Speed *Time.deltaTime);
		}
		
	}
}