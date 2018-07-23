using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {
    public GameObject BlockA;
    public int counter = 0;
    public float maxCount = 90;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (counter < maxCount)
        {
            counter++;
        }
        else
        {
            Instantiate(BlockA);
            counter = 0;
            maxCount = maxCount - 2f;
        }
	}
}
