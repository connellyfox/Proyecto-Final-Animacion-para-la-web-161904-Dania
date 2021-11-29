using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform blob;

    void Update()
    {
        if (blob != null)
        {
            Vector3 position = transform.position;
            position.x = blob.position.x;
            transform.position = position;
        }
    }
}