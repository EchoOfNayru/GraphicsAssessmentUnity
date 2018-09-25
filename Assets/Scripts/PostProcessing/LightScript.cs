using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour {

    public string type;
    public float intensityMax;
    public float intensityMin;
    public Transform on, off;

	// Use this for initialization
	void Awake () {
        if (type == "d")
        {
            if (SceneManager.instance.day == null)
            {
                SceneManager.instance.day = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        if (type == "n")
        {
            if (SceneManager.instance.night == null)
            {
                SceneManager.instance.night = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }
	}

    private void Start()
    {
        if (type != "d")
        {
            //GetComponent<Light>().intensity = 0;
        }
    }

    public void ChangeToNoon()
    {
        SceneManager.instance.day.transform.LookAt(on);
        SceneManager.instance.night.transform.LookAt(off);
    }

    public void ChangeToMidnight()
    {
        SceneManager.instance.day.transform.LookAt(off);
        SceneManager.instance.night.transform.LookAt(on);
    }
}
