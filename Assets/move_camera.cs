using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float speed = 3.0f;
    float angle = 100.0f;
    
    // Update is called once per frame
    void Update()
    {
        Camera camera = GetComponent<Camera>();
        if(Input.GetKey(KeyCode.UpArrow))
        {
            camera.transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            camera.transform.Translate(-Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            camera.transform.Translate(new Vector3(1,0,0)* speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            camera.transform.Translate(new Vector3(-1,0,0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Comma))
        {
            camera.transform.Rotate(Vector3.up, -angle * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Slash))
        {
            camera.transform.Rotate(Vector3.up, angle * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Period))
        {
            var currEulerAngles = transform.eulerAngles;
            currEulerAngles.x += speed * Time.deltaTime * 5;
            transform.rotation = Quaternion.Euler( currEulerAngles );
        } 
        if (Input.GetKey(KeyCode.L))
        {
            var currEulerAngles = transform.eulerAngles;
            currEulerAngles.x -= speed * Time.deltaTime * 5;
            transform.rotation = Quaternion.Euler( currEulerAngles );
        }
    }
}
