
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotalManager : MonoBehaviour {

    public string type;
    public float value = 0;
    public GameObject portal;
    Rigidbody2D rigid;


    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == 9 && rigid.velocity.y < 0)
        {

            BlockStatus block = other.gameObject.GetComponent<BlockStatus>
                Debug.Log(block.type) {

            }
        }
    }

}
