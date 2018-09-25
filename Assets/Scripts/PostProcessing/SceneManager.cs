using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

    public static SceneManager instance;

    public float daySpeed;

    public bool isRaining, isSnowing;


    [HideInInspector]
    public LightScript day;
    [HideInInspector]
    public LightScript night;
    [HideInInspector]
    public UIManager uiManager;
    [HideInInspector]
    public ParticleManager particles;

    private void Awake()
    {
        if (SceneManager.instance == null)
        {
            SceneManager.instance = this;
        }
    }

    private void FixedUpdate()
    {
        DayNightCycle();
    }

    void DayNightCycle()
    {
        day.transform.Rotate(Vector3.up * -daySpeed);

        night.transform.Rotate(Vector3.up * -daySpeed);
    }

    public void StartSnow()
    {
        var boop = particles.snow.emission;
        if (isSnowing)
        {
            boop.rateOverTime = 0;
            isSnowing = false;
        }
        else
        {
            boop.rateOverTime = particles.snowRate;
            isSnowing = true;
        }
    }

    public void StartRain()
    {
        if (isRaining)
        {
            particles.rain.gameObject.SetActive(false);
        }
        else
        {
            particles.rain.gameObject.SetActive(true);
        }
    }
}
