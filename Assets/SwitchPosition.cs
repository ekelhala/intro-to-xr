using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SwitchPosition : MonoBehaviour
{
    public GameObject rig;
    public InputActionReference action;
    private bool state = true;

    // Start is called before the first frame update
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if(state)
            {
                this.transform.position = new Vector3(-33.19f, 2.9340f, -23.69f);
                state = false;
            }
            else
            {
                this.transform.position = new Vector3(-2.61f, 3.45f, -5.24f);
                state = true;
            }

 
        };

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
