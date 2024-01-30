using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;
    private bool lightState = true;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += (ctx) => {
            if(lightState) {
                light.color = new Color(1.0f,0.0f,0.0f);
                lightState = false;
            }
            else {
                light.color = new Color(0.0f,1.0f,0.0f);
                lightState = true;
            }
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
