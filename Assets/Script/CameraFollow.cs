using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject target;
    public Transform targetX;
    public Vector3 offset;
    public Vector3 startPosition;
    

    public void Start()
    {
        startPosition = transform.position;

    }

    private void LateUpdate()
    {
        Vector3 position = transform.position;
        position.y = (targetX.position + offset).y;
        transform.position = position;

       

    }
}
