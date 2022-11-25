using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpen : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;

    private bool doorc = true;

    void Update()
    {
       if (Input.GetKey(KeyCode.M) && doorc)
        {
            myDoor.Play("DoorOpen",0,0.0f);
            doorc = false ;
        }
        if (Input.GetKey(KeyCode.N) && !doorc)
        {
            myDoor.Play("DoorClose",0,0.0f);
            doorc = true;
        }
    }
}
