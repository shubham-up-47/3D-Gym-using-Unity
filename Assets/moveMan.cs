using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMan : MonoBehaviour
{ 
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        transform.Translate(0, 0, Time.deltaTime*Speed);
        if(Input.GetKey(KeyCode.V))`
        transform.Translate(0, 0, -1*Time.deltaTime*Speed);
        if (Input.GetKey(KeyCode.C))
        transform.Translate(-1*Time.deltaTime*Speed, 0, 0);
        if(Input.GetKey(KeyCode.B))
        transform.Translate(Time.deltaTime*Speed, 0, 0);
        
    }
}
