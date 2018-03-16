using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise2 : MonoBehaviour {
    public int grade;

	// Use this for initialization
	void Start () {
        if (grade  >= 80 && grade < 100)
        {
            print("A");
        }
        else if (grade >= 70 && grade < 80)
        {
            print("B");
        }
        else if (grade >= 60 && grade >70)
        {
            print("C");
        }
        else if (grade >= 50 && grade < 60)
        {
            print("D");
        }
        else if (grade >= 30 && grade < 50)
        {
            print("E");
        }
        else
        {
            print("F");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
