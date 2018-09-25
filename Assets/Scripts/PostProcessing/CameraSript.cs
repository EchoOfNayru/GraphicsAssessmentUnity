using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class CameraSript : MonoBehaviour {

    //PostProcessVolume m_Volume;
    //Vignette m_Vignette;

    //public CubeHealth cube;

    //ColorParameter m_Color = new ColorParameter { value = new Color(1f, 0f, 0f, 1f) };

private void Start()
    {
        //m_Vignette = ScriptableObject.CreateInstance<Vignette>();
        //m_Vignette.enabled.Override(false);
        //m_Vignette.intensity.Override(1f);

        //m_Volume = PostProcessManager.instance.QuickVolume(gameObject.layer, 100f, m_Vignette);
    }

    private void Update()
    {
        //if (cube.health <= cube.healthMax / 2)
        //{
            
        //    m_Vignette.enabled.Override(true);
        //    m_Vignette.color.Override(m_Color);
        //}
        //else
        //{
        //    m_Vignette.enabled.Override(false);
        //}
    }
}
