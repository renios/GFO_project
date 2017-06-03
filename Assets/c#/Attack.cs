using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		sr = gameObject.GetComponent<SpriteRenderer>();
		sr.enabled = false;
	}

	IEnumerator test()
	{
		sr.enabled = true;
		yield return new WaitForSeconds(0.5f);
		sr.enabled = false;

		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
			StartCoroutine("test");
		}
	}
}
