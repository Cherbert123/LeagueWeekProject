using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMover : MonoBehaviour {
    private float Timer = 40;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Timer <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            gameObject.transform.position = gameObject.transform.position - new Vector3(.1f, 0f, 0f);
            Timer = Timer - .1f;
        }
	}
}
