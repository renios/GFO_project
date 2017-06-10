using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class story4 : MonoBehaviour {

	public Text textObject;	
	public int num;
	// Use this for initialization
	void Start () {
		num = 10;
	}
	
	// Update is called once per frame
	void Update () {
		if (num == 10)
		{
			textObject.text = "봐라. 안죽는다고 하지 않았느냐.";
		}
		else 
		{
			textObject.gameObject.SetActive(false);
		}
	}

	public void Click () {
		num = num+1;
	}
}
