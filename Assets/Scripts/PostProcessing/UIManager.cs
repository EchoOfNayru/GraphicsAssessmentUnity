using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    [Header ("")]
    public Button Noon;
    public Button Midnight;

    private void Awake()
    {
        if (SceneManager.instance.uiManager == null)
        {
            SceneManager.instance.uiManager = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
