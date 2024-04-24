using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; 
    public Vector3 offset = new Vector3(0f, 2f, -10f); 

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 newPosition = target.position + offset;
            transform.position = newPosition;
        }
    }
}