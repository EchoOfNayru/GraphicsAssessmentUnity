using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Akai : MonoBehaviour {

    public Animator thing;

    private void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            thing.SetBool("isBellyDancing", true);
        }
        if(Input.GetKeyUp("w"))
        {
            thing.SetBool("isBellyDancing", false);
        }

        if (Input.GetKeyDown("q"))
        {
            thing.SetBool("isMacarena", true);
        }
        if (Input.GetKeyUp("q"))
        {
            thing.SetBool("isMacarena", false);
        }

        if (Input.GetKeyDown("e"))
        {
            thing.SetBool("isTwist", true);
        }
        if (Input.GetKeyUp("e"))
        {
            thing.SetBool("isTwist", false);
        }

        if (Input.GetKeyDown("r"))
        {
            thing.SetBool("isYmca", true);
        }
        if (Input.GetKeyUp("r"))
        {
            thing.SetBool("isYmca", false);
        }
    }
}
