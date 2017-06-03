using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_3 : MonoBehaviour {

    public float movePower = 6f;
    public float jumpPower = 20f;
    public int maxHealth = 3;

    public bool inputLeft = false;
    public bool inputRight = false;
    public bool inputJump = false;

    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;

	// Use this for initialization
	

    // Update is called once per frame
    void Update() {
        //if ((!inputRight && !inputLeft )){
        //animator.SetBool("isMoving",false);
    //}
		if(inputLeft)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (inputRight)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
	}
}
