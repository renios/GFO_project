using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour {

	public GameObject expObject;
	public GameObject potionObject;

	public int dropProbability;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DropExp(int point)
	{
		if (expObject != null)
		{
			float delta = Random.Range(-0.5f, 0.5f);
			GameObject newExpObject = Instantiate(expObject, gameObject.transform.position + new Vector3(delta, 0, 0), Quaternion.identity) as GameObject;
			// newExpObject.GetComponent<ExpObject>().SetExp(point);
		}
	}

	public void DropPotion()
	{
		int num = Random.Range(0, dropProbability);
		if (num == 0)
		{
			float delta = Random.Range(-0.5f, 0.5f);
			Instantiate(potionObject, gameObject.transform.position + new Vector3(delta, 0, 0), Quaternion.identity);			
		}
	}
}
