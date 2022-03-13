using UnityEngine;
using System.Collections;
using UnityEngine.Experimental.Rendering.Universal;

public class TurnOnAndOff : MonoBehaviour
{
    private Light2D myLight;


    void Start()
    {
        myLight = GetComponent<Light2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }
    }
}