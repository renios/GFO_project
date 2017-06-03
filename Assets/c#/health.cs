using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour {
	public int player_helath;
	public Text textobject;
	

	// Use this for initialization
	void Start () {
		player_helath = 30;
		textobject.text = "채력:" + player_helath;

		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.O)){
			Damaged(1);
			// player_helath--;
			textobject.text = "채력:" + player_helath;
		}
	}

	void Damaged(int damage)
	{
		

	}
}
