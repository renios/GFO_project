using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hunt : MonoBehaviour 
{

	// Use this for initialization
	public int num;
	void Start () 
	{
		num = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (num == 10) 
		{
			SceneManager.LoadScene ("hunting");
		}
	}
	public void Click ()
	{
		num = num + 1;
	}
}
