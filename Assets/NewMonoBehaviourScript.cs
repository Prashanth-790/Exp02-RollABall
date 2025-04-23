using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float xForce = 5.0f;
    public float yForce = 5.0f;
    public float zForce = 100.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x=0.0f,y=0.0f,z=0.0f;
        if(Input.GetKey(KeyCode.A)){
            x=x-xForce;
        }

        if(Input.GetKey(KeyCode.D)){
            x=x+xForce;
        }

        if(Input.GetKey(KeyCode.W)){
            z=z-zForce;
        }
        if(Input.GetKey(KeyCode.X)){
            z=z+zForce;
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            y=yForce;
        }
        GetComponent<Rigidbody>().AddForce(x,y,z);
            
            
    }
}