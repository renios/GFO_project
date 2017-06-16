using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAttack : MonoBehaviour {

	public int damage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			if (other.transform.position.x < gameObject.transform.position.x)
			{
				other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * 2 + Vector2.up, ForceMode2D.Impulse);
				other.gameObject.GetComponent<playerHealth>().Damaged(damage);
			}
			else if (other.transform.position.x < gameObject.transform.position.x)
			{
				other.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 2 + Vector2.up, ForceMode2D.Impulse);
				other.gameObject.GetComponent<playerHealth>().Damaged(damage);
			}
		}
	}
}
