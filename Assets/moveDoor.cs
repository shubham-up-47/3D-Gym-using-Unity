using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveDoor : MonoBehaviour
{ 
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        transform.Translate(Time.deltaTime*Speed, 0, 0);
        if(Input.GetKey(KeyCode.X))
        transform.Translate(-1*Time.deltaTime*Speed, 0, 0);
    }
}
