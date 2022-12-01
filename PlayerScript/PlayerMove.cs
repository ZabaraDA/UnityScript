using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
     public float _speed;
     public float _speedRotation;

    void Update()
    {


        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 offset = new Vector3(h,0,v) * _speed * Time.deltaTime;
        transform.Translate(offset);

        float y = Input.GetAxis("Mouse X");
        transform.Rotate(0, y * _speedRotation * Time.deltaTime, 0);


        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            transform.localScale = new Vector3(1f, 0.5f, 1f);
        }
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
