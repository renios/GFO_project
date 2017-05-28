using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_1 : MonoBehaviour {
    public float movePower = 1f;

    Animator animator;
    Vector3 movement;
    int movementFlag = 0;


	// Use this for initialization
	void Start () {
        animator = gameObject.GetComponentInChildren<Animator>();

        StartCoroutine("ChangeMovement");
	}
    IEnumerator ChangeMovement()
    {
        movementFlag = Random.Range(0, 3);
        Debug.Log("송신중");
        if (movementFlag == 0)
            animator.SetBool("isMoving", false);
        else
            animator.SetBool("isMoving", true);
        yield return new WaitForSeconds(2f);
        Debug.Log("송신완료");
        StartCoroutine("ChangeMovement");
    }

    public void FixedUpdate()
    {
        Move();
    }
    public void Move ()
    {
        Vector3 moveVelocity = Vector3.zero;

        if(movementFlag == 1)
        {
            moveVelocity = Vector3.left;
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (movementFlag == 2)
        {
            moveVelocity = Vector3.right;
            transform.localScale = new Vector3(-1, 1, 1);

        }
        transform.position += moveVelocity * movePower * Time.deltaTime;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
