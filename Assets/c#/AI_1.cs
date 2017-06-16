using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_1 : MonoBehaviour {
    public float movePower = 1f;
    float originMovePower;

    // Animator animator;
    Vector3 movement;
    int movementFlag = 0;
    public int creatrueType;
    private bool isTracing;
    private GameObject traceTarget;
    Vector3 originalScale;
    public GameObject spriteObject;


    // Use this for initialization
    void Start () {
        originMovePower = movePower;
        originalScale = transform.localScale;
        StartCoroutine("ChangeMovement");
	}
    IEnumerator ChangeMovement()
    {
        while (true) {
            movementFlag = Random.Range(0, 3);
            yield return new WaitForSeconds(1f);
        }
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
            movePower = originMovePower * 2;
            transform.localScale = originalScale * 1f;
            Vector3 playerPos = traceTarget.transform.position;

            if (playerPos.x < transform.position.x)
                dist = "Left";
            else if (playerPos.x > transform.position.x)
                dist = "Right";
        }
        else
        {
            movePower = originMovePower;
            transform.localScale = originalScale * 0.8f;
            if (movementFlag == 1)
                dist = "Left";
            else if (movementFlag == 2)
                dist = "Right";
        }

        if (dist == "Left")
        {
            moveVelocity = Vector3.left;
            spriteObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (dist == "Right")
        {
            moveVelocity = Vector3.right;
            spriteObject.transform.localRotation = Quaternion.Euler(0, 180, 0);

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
