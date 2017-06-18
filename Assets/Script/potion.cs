using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potion : MonoBehaviour {

	public int healAmount;

	void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			other.gameObject.GetComponent<playerHealth>().Heal(healAmount);
			Destroy(gameObject);
		}
	}
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
