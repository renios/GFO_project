using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class story3 : MonoBehaviour {

	public Text textObject;	
	public int num;
	// Use this for initialization
	void Start () {
		num = 9;
	}
	
	// Update is called once per frame
	void Update () {
		if (num == 9)
		{
			textObject.text = "우린 너희를 살리려 했을 뿐이다. 어차피 우리 종족은 인간의 공격으로는 단번에 죽지 않아. ";
		}
		else 
		{
			gameObject.SetActive(false);
			FindObjectOfType<BossAttack>().AttackStart();
		}
	}

	public void Click (){
		num = num+1;
	}
}
