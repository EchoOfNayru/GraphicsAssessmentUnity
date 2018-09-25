using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour {

    public Material normal, snow;
    float lerpAmount = 0f;


    private void Update()
    {
        GetComponent<Renderer>().material.Lerp(normal, snow, lerpAmount);
        if (SceneManager.instance.isSnowing)
        {
            //GetComponent<Renderer>().material.color = new Color(GetComponent<Renderer>().material.color.r + 1, GetComponent<Renderer>().material.color.g + 1, GetComponent<Renderer>().material.color.b + 1);
            //GetComponent<Renderer>().material = snow;
            if (lerpAmount < 1)
            {
                lerpAmount += 0.001f;
            }
        }
        else
        {
            //GetComponent<Renderer>().material = normal;
            if (lerpAmount > 0)
            {
                lerpAmount -= 0.002f;
            }
        }
    }
}
