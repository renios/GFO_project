using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Kill : MonoBehaviour {
    public readonly int maxHealth = 30;
    public string nextScene;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(maxHealth < 0)
        {
            Debug.Log("플레이어 사망!!");
            SceneManager.LoadScene(nextScene);
         
        }
	
	}
    



}
