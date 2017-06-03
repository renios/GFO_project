using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potion : MonoBehaviour {
public void OnTriggerEnter2D(Collider2D other)
{
		if(other.gameObject.tag == "Player")
		{
			FindObjectOfType<health>().Heal(5);
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
