using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal : MonoBehaviour {

	public string nextSceneName;

	public void OnTriggerStay2D(Collider2D other)
	{
		if(other.gameObject.tag == "Player")
		{
			SceneManager.LoadScene(nextSceneName);
            
		}
	}
}
