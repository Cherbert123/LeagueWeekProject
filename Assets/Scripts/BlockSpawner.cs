using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour {
    public GameObject BlockA;
    public float counter = 0;
    public float maxCount = 90;
    public bool doesScale = true;
    public float modifier = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (counter < maxCount)
        {
            counter = counter + 1/modifier;
        }
        else
        {
            GameObject block = Instantiate(BlockA);
            if (doesScale)
            {
                block.transform.localScale = new Vector3(Random.Range(1f, 1.5f), Random.Range(1f, 1.5f), 0);
            }
            counter = 0;
            maxCount = Random.Range(60,120);
        }
	}
}
