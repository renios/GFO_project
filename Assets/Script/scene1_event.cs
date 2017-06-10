using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scene1_event : MonoBehaviour {

	public GameObject button;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
        if (other.gameObject.tag == "Player")
        {
            button.SetActive(true);
			button.GetComponent<scene1_story>().SetNum(4);
			gameObject.GetComponent<Collider2D>().enabled = false;
        }
	}
}
