using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
  
    public float rotationSpeed = -50f;
    public bool isRotationActive = true;

    void Update()
    {
        if (isRotationActive)
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }

    }
}
