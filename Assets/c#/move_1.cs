using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_1 : MonoBehaviour {
	public int Speed;
	bool leftButtonClicked = false;
	bool rightButtonClicked = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.D) || rightButtonClicked) {
			transform.Translate (Vector3.right * Speed * Time.deltaTime);
		}
		if(Input.GetKey (KeyCode.A) || leftButtonClicked) {
			transform.Translate (Vector3.left * Speed * Time.deltaTime);
		}
		
	}

	public void MoveLeftButtonDown()
	{
		leftButtonClicked = true;
	}

	public void MoveLeftButtonUp()
	{
		leftButtonClicked = false;
	}

	public void MoveRightButtonDown()
	{
		rightButtonClicked = true;
	}

	public void MoveRightButtonUp()
	{
		rightButtonClicked = false;
	}
}
