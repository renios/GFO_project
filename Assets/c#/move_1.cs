using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_1 : MonoBehaviour {
	public int Speed;
	bool leftButtonClicked = false;
	bool rightButtonClicked = false;

	bool JumpButton = false;

	Animator animator;
	Attack attack;

	public Collider2D groundChecker;
	public GameObject spriteObject;

	// Use this for initialization
	void Start () {
		animator = spriteObject.GetComponent<Animator>();
		attack = GetComponentInChildren<Attack>();
	}

	bool IsGround()
	{
		// groundChecker.
		return false;
	}
	
	// Update is called once per frame
	void Update () {
		if(rightButtonClicked) {
			transform.position += Vector3.right * Speed * Time.deltaTime;
			spriteObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
			attack.direction = Vector2.right;
		}
		if(leftButtonClicked) {
			transform.position += Vector3.left * Speed * Time.deltaTime;
			spriteObject.transform.localRotation = Quaternion.Euler(0, 180, 0);
			attack.direction = Vector2.left;
		}
		if(JumpButton) {
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * 7, ForceMode2D.Impulse);
			// transform.position += Vector3.up * Speed * 2 * Time.deltaTime;
			JumpButton = false;
	
		}

		if (leftButtonClicked || rightButtonClicked)
			animator.SetFloat("speed", 1.0f);
		else
			animator.SetFloat("speed", 0);
		
		if (Input.GetKeyDown(KeyCode.D))
			MoveRightButtonDown();
		if (Input.GetKeyUp(KeyCode.D))
			MoveRightButtonUp();
		if (Input.GetKeyDown(KeyCode.A))
			MoveLeftButtonDown();
		if (Input.GetKeyUp(KeyCode.A))
			MoveLeftButtonUp();

		if (Input.GetKeyDown(KeyCode.W))
			JumpButtonDown();
			
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
	public void JumpButtonUp()
	{
		JumpButton = false;
	}
	public void JumpButtonDown()
	{
		JumpButton = true;
	}
}
