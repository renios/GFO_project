using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonManger : MonoBehaviour {
    GameObject player;
    move_3 playerScript;

    public void Init()
    {
        player = GameObject.FindGameObjectWithTag("player");
        playerScript = player.GetComponent<move_3>();
    }

    public void LeftDown()
    {
        playerScript.inputLeft = true;
    }
    public void LeftUp()
    {
        playerScript.inputLeft = false;
    }
    public void RightDown()
    {
        playerScript.inputRight = true;
    }
    public void RightUp()
    {
        playerScript.inputRight = false;
    }
    public  void LeftClick()
    {
        Debug.Log("왼쪽버튼 누름");
    }
    public void RightClick()
    {
        Debug.Log("오른쪽 버튼 누름");
    }
    public void JumpClick()
    {
        Debug.Log("점프 버튼 누름");
    }

}
