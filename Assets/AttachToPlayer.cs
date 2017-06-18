using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToPlayer : MonoBehaviour {

	bool moveToPlayer;
	GameObject player;

	// Use this for initialization
	void Start () {
		moveToPlayer = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (moveToPlayer)
		{
			Vector3 distance = player.transform.position + (Vector3.up * 1.5f) - gameObject.transform.position;
			if (distance.sqrMagnitude < 0.5f)
			{
				Destroy(gameObject.transform.parent.gameObject);
			}
			else
			{
				gameObject.transform.parent.position += distance * Time.deltaTime * 4.0f; 	
			}
		}
	}

	void OnTriggerStay2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			this.gameObject.GetComponent<CircleCollider2D>().enabled = false;
			transform.parent.gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
			transform.parent.gameObject.GetComponent<Collider2D>().enabled = false;
			player = other.gameObject;
			moveToPlayer = true;
		}
	}
}
