using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class LightFlicker : MonoBehaviour
{

    public GameObject flickerLight;
    public VisualEffect vfx;

    // Start is called before the first frame update
    void Start()
    {
        flickerLight.SetActive(false);
        //light.intensity = 0;
        Invoke("RandomThing", 0.5f);

    }
    void RandomThing()
    {
        float randomTime = Random.Range(0.5f, 3f);
        flickerLight.SetActive(false);
        //light.intensity = 25;
        vfx.Play();
        Invoke("TurnOffLight", 0.2f);
        Invoke("RandomThing", randomTime);
    }
    void TurnOffLight()
    {
        flickerLight.SetActive(false);
    }
}

