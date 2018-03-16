using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exercise3 : MonoBehaviour {
    int MaxHealth = 100;
    int health;
    int damage = 10;    
    // Use this for initialization
    void Start () {
        health = MaxHealth;

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Space))
        {
            health -= damage;
            if (health == 20)
            {
                print("Low Health");
            }
            else if (health == 0)
            {
                print("Mission Failed, Character is dead");
            }
        }
       
    }
}
