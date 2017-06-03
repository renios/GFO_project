using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_1 : MonoBehaviour {
    public float movePower = 1f;

    // Animator animator;
    Vector3 movement;
    int movementFlag = 0;
    public int creatrueType;
    private bool isTracing;
    private GameObject traceTarget;
    Vector3 originalScale;


    // Use this for initialization
    void Start () {
        originalScale = transform.localScale;
        StartCoroutine("ChangeMovement");
	}
    IEnumerator ChangeMovement()
    {
        movementFlag = Random.Range(0, 3);
        Debug.Log("송신중");
        // if (movementFlag == 0)
        //     animator.SetBool("isMoving", false);
        // else
        //     animator.SetBool("isMoving", true);    
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
        string dist = "";
      
        if (isTracing)
        {
            Vector3 playerPos = traceTarget.transform.position;

            if (playerPos.x < transform.position.x)
                dist = "Left";
            else if (playerPos.x > transform.position.x)
                dist = "Right";
        }
        else
        {
            if (movementFlag == 1)
                dist = "Left";
            else if (movementFlag == 2)
                dist = "Right";
        }

        if (dist == "Left")
        {
            moveVelocity = Vector3.left;
            transform.localScale = originalScale * 1.0f;
        }
        else if (dist == "Right")
        {
            moveVelocity = Vector3.right;
            transform.localScale = originalScale * 0.5f;

        }
        transform.position += moveVelocity * movePower * Time.deltaTime;
    }

    // Update is called once per frame
    void Update () {
		
	}
    public void OnTriggerStay2D(Collider2D other)
    {
        if (creatrueType == 0)
            return;

        if (other.gameObject.tag == "Player")
        {
            isTracing = true;
        }
 
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (creatrueType == 0)
            return;

        if (other.gameObject.tag == "Player")
        {
            isTracing = false;

            StartCoroutine("ChangeMovement");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (creatrueType == 0)
            return;

        if (other.gameObject.tag == "Player")
        {
            traceTarget = other.gameObject;

            StopCoroutine("ChangeMovement");



        }
    }
   

     
}
