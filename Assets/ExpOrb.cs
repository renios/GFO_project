using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpOrb : MonoBehaviour {

	int exp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnColliderEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			// other.gameObject.GetComponent<playerHealth>().Heal(healAmount);
			Destroy(gameObject);
		}	
	}

	public void SetExp(int amount)
	{
		exp = amount;
	}
}
