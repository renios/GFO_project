using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class story4 : MonoBehaviour {

	public Text textObject;	
	public int num;
	public Image darkImage;
	// Use this for initialization
	void Start () {
		num = 10;
		darkImage.color = new Color(0,0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		if (num == 10)
		{
			textObject.text = "봐라. 안죽는다고 하지 않았느냐.";
		}
		else 
		{
			StartCoroutine(GotoTitle());
		}
	}

	IEnumerator GotoTitle()
	{
		yield return new WaitForSeconds(1f);
		for (int i = 0; i < 20; i++)
		{
			darkImage.color += new Color(0,0,0,0.05f);
			yield return new WaitForSeconds(0.2f);	
		}

		yield return new WaitForSeconds(1f);
		SceneManager.LoadScene("Scene_title");
	}

	public void Click () {
		num = num+1;
	}
}
