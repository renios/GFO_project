using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbMove : MonoBehaviour {

	public int damage;

	bool moveToPlayer;
	Vector3 playerPos;

	// Use this for initialization
	IEnumerator Start () {
		moveToPlayer = false;
		yield return new WaitForSeconds(1f);
		playerPos = FindObjectOfType<playerHealth>().gameObject.transform.position;
		moveToPlayer = true;
		Destroy(gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		if (moveToPlayer)
		{
			Vector3 distance = playerPos + Vector3.left + (Vector3.up * 1.5f) - gameObject.transform.position;
			if (distance.sqrMagnitude < 0.1f)
			{
				Destroy(gameObject);
			}
			else
			{
				gameObject.transform.position += distance * Time.deltaTime * 4.0f; 	
			}
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