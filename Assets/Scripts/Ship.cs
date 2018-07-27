using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {
    public int move = 800;
    public string forwards = "WF";
    public GameObject cannonball;
    public int fired = 1;
    private int tFire = 1;
	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        if (forwards == "Back" & move != 0) {
            Vector3 tempPos = new Vector3(gameObject.transform.position.x + .1f,gameObject.transform.position.y,gameObject.transform.position.z);
            gameObject.transform.position = tempPos;
            move = move - 1;
        }
        if (forwards == "For" & move != 0)
        {
            Vector3 tempPos = new Vector3(gameObject.transform.position.x - .1f, gameObject.transform.position.y, gameObject.transform.position.z);
            gameObject.transform.position = tempPos;
            move = move - 1;
        }
        if (forwards == "For" & move <= 0) {
            forwards = "WB";
            move = 200;
        }
        if (forwards == "Back" & move <= 0)
        {
            forwards = "WF";
            move = 800;

        }
        if (forwards == "WB" & move != 0)
        {
            move = move - 1;
            if (fired > 0)
            {
                Instantiate(cannonball);
                fired = fired - 1;
            }
        }
        if (forwards == "WB" & move <= 0)
        {
            forwards = "Back";
            move = 80;
            tFire = tFire * 3;
            fired = tFire;
        }
        if (forwards == "WF" & move != 0)
        {
            move = move - 1;
        }
        if (forwards == "WF" & move <= 0)
        {
            forwards = "For";
            move = 80;
        }
       
	}
}
