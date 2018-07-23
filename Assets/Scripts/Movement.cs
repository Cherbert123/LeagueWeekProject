﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Rigidbody2D rigBody;
    public bool canJump = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey("w") & canJump == true){
            canJump = false;
            rigBody.AddForce(Vector3.up * 260);
        }

	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.gameObject.tag == "Ground"){
           canJump = true;
        }
	}
}
