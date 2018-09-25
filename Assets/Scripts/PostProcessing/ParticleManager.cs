using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour {

    public ParticleSystem snow, rain;

    public int snowRate = 1000;

    private void Awake()
    {
        if (SceneManager.instance.particles == null)
        {
            SceneManager.instance.particles = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
