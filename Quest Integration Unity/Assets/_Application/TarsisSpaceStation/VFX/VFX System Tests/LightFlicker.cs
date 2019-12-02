using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.VFX;

public class LightFlicker : MonoBehaviour
{

    public GameObject light;
    public VisualEffect vfx;

    // Start is called before the first frame update
    void Start()
    {
        light.active = false;
        //light.intensity = 0;
        Invoke("RandomThing", 0.5f);

    }
    void RandomThing()
    {
        float randomTime = Random.Range(0.5f, 3f);
        light.active = true;
        //light.intensity = 25;
        vfx.Play();
        Invoke("TurnOffLight", 0.2f);
        Invoke("RandomThing", randomTime);
    }
    void TurnOffLight()
    {
        light.active = false;
        //light.intensity = 0;
    }
}

