using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    public Rigidbody2D rigBody;
    public ParticleSystem particles;
    public bool canJump = true;
    public GameObject playerBox;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey("w") & canJump == true){
            canJump = false;
            rigBody.AddForce(Vector3.up * 260);
            particles.Stop();
        }
        if (Input.GetKey("a"))
        {
            Rigidbody2D rigP = playerBox.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
            rigP.AddForce(Vector3.left);
        }
        if (Input.GetKey("d"))
        {
            Rigidbody2D rigP = playerBox.GetComponent(typeof(Rigidbody2D)) as Rigidbody2D;
            rigP.AddForce(Vector3.right);
        }

	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.gameObject.tag == "Ground"){
           canJump = true;
            particles.Play();
        }
	}
}
