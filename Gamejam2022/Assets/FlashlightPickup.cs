using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Rendering.Universal;

public class FlashlightPickup : MonoBehaviour
{
    public static Light2D myLight;


    void Start()
    {
        myLight = GetComponent<Light2D>();
        myLight.intensity = 1.5f;
    }


    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    myLight.enabled = !myLight.enabled;
        //}
    }
}