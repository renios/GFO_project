using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_1 : MonoBehaviour {
    public int Speed;
    bool JumpButton = false;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.Space) || JumpButton)
        {
            transform.position += Vector3.up * Speed * Time.deltaTime;
        }



        
    }
    public void JumpButtonUp()
    {
        JumpButton = false;
    }
    public void JumpButtonDown()
    {
        JumpButton = true;
    }
}
