using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storytest : MonoBehaviour {

	public Text textObject;
	public int num;
	// Use this for initialization
	void Start () {
		num = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (num ==0)
		{
			textObject.text = "아들아 우리의 해가 서쪽으로 지고 있다. 왕에게 문제가 있는 것 같구나.";
		}
		else if (num == 1)
		{
			textObject.text = "마을의 건장한 청년은 모두 끌려가 너희 형마저 전쟁터에 갔으니 왕에게 무슨일이 있는지 알 도리가 없구나. 네가 가야겠다. ";
		}
		else if (num == 2)
		{
			textObject.text = "네 어머니.";
		}	
		else if  (num == 3)
		{
			textObject.text = "아들아!!!!";
		}
		else if (num == 4)
		{
			textObject.text = "?";
		}
		else if (num == 5)
		{
			textObject.text = "돌아가신 너희 아빠가 남긴 검이다. 상처가 생긴다면 이 물약을 먹거라.";
		}
		else if (num ==6)
		{
			textObject.text = "주인공 능력치: 검 공격력 4 체력 20 ";
		}
		else if (num == 7)
		{
			textObject.text = "형!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!"; 
		}
		else if (num == 8)
		{
			textObject.text = "아…..미안…";
		}
		else if (num == 9)
		{
			textObject.text = "......";
		}
		else if (num == 10)
		{
			textObject.text = "주인공 능력치: 공격력 5 체력 22";
		} 
		else if (num == 11)
		{
			textObject.text = "우린 너희를 살리려 했을 뿐이다. ";
		}
		else if (num == 12)
		{
			textObject.text = "........";
		}

	}

	public void Printstory() {
		textObject.text = "text";
	}
	public void Click() {
		num = num+1;
	}

}
