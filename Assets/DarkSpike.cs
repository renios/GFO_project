using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkSpike : MonoBehaviour {

	public int delay;
	public int speed;
	public int damage;

	bool move = false;

	// Use this for initialization
	IEnumerator Start () {
		yield return new WaitForSeconds(delay);
		move = true;
		Destroy(gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		if (move)
		{
			transform.position += Vector3.up * Time.deltaTime * speed;
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			other.gameObject.GetComponent<playerHealth>().Damaged(damage);
		}
	}
}
