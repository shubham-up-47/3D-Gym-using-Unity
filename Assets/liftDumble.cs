using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class liftDumble : MonoBehaviour
{
    public float Speed;

    // update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        transform.Translate(Time.deltaTime*Speed, 0, 0);
        if(Input.GetKey(KeyCode.S))
        transform.Translate(-1*Time.deltaTime*Speed, 0, 0);
    }
}



