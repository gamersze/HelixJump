using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CylinderTurning : MonoBehaviour
{

    public Vector3 startPosition;

    float firstPos, endPos;
    public float rotateSpeed;
     float moveX;

    void Start()
    {
        startPosition = transform.position;
    }

   
    void Update()
    {

        moveX = Input.GetAxis("Mouse X");

        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0, -moveX * rotateSpeed * Time.deltaTime, 0f);
            
        }
       
    }
}
