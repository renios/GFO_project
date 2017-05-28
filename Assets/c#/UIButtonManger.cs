using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonManger : MonoBehaviour {
   public GameObject player;
   public move_3 playerScript;
    public void Init ()
    {
        player = GameObject.FindGameObjectWithTag("player");
        playerScript = player.GetComponent<move_3>();
    }
    public void  LeftDown ()
    {
        playerScript.inputLeft = true;
    }
    public void LeftUp()
    {
        playerScript.inputLeft = false;
    }
    public void RightDown ()
    {
        playerScript.inputRight = true;
    }
    public void RightUp ()
    {
        playerScript.inputRight = false;
    }


    public void LeftClick ()
    {
        Debug.Log("왼쪽 버튼을클릭하였다");
    }
    public void RightClick ()
    {
        Debug.Log("오른쪽 버튼을 클릭하였다.");
    }
    public void JumpClick ()
    {
        playerScript.inputJump = true;
        Debug.Log("점프 버튼을 클릭하였다");
    }
    //Debug은 태스트를 위한것 ㅇㅁㅇ.    
    


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
