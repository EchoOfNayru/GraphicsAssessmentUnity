using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeHealth : MonoBehaviour {

    public int healthMax;
    public int health;

    private void Start()
    {
        health = healthMax;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            health -= 10;
            if (health < 0)
            {
                health = 0;
            }
        }
    }
}
