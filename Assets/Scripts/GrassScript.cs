using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassScript : MonoBehaviour {

    public float windPower;

    SpriteRenderer rend;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Mathf.Clamp(windPower, 0f, 1f);
        rend.material.SetFloat("_ShakeTime", windPower);
        rend.material.SetFloat("_ShakeWindspeed", windPower);
        rend.material.SetFloat("_ShakeBending", windPower * 1.5f);
    }
}
