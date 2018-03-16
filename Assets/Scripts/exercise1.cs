using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise1 : MonoBehaviour {
    public float physics = 151.7f;
    public float maths = 183.0f;
    public float ukrainian = 167.9f;
    float passing_score = 150.0f;
    // Use this for initialization
    void Start () {
        if (physics >= passing_score && maths >= passing_score && ukrainian >= passing_score)
        {
            print("Success");
        }
        else
        {
            print("Failed");
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
        