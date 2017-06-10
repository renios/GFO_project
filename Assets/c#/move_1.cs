using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_1 : MonoBehaviour {
	public int Speed;
	bool leftButtonClicked = false;
	bool rightButtonClicked = false;

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey (KeyCode.D) || rightButtonClicked) {
			transform.position += Vector3.right * Speed * Time.deltaTime;
			transform.localRotation = Quaternion.Euler(0, 0, 0);
		}
		if(Input.GetKey (KeyCode.A) || leftButtonClicked) {
			transform.position += Vector3.left * Speed * Time.deltaTime;
			transform.localRotation = Quaternion.Euler(0, 180, 0);
		}

		if (leftButtonClicked || rightButtonClicked)
			animator.SetFloat("speed", 1.0f);
		else
			animator.SetFloat("speed", 0);
		
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
