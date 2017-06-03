using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class story2 : MonoBehaviour {

	public Text textObject;	
	public int num;
	// Use this for initialization
	void Start () {
		num = 6;
	}
	
	// Update is called once per frame
	void Update () {
		if (num == 6)
		{
			textObject.text = "형!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"; 
		}
		else if (num == 7)
		{
			textObject.text = "아…..미안…";
		}
		else if (num == 8)
		{
			textObject.text = "......";
		}
		else 
		{
			SceneManager.LoadScene("3");
		}
	}

	public void Click (){
		num = num+1;
	}
}
