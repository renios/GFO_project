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
		textobject.text = "체력:" + player_helath;

		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.O)){
			Damaged(1);
		}
		if(Input.GetKeyDown(KeyCode.H)){
			Heal(1);
		}

		textobject.text = "채력:" + player_helath;
	}

	public void Heal(int heal)
	{
		player_helath += heal;
	}

	public void Damaged(int damage)
	{
		player_helath -= damage;
	}
}
