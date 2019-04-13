using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
  
    public Transform earthTransform;
    public float rotationSpeed = -50f;
    public bool isRotationActive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotationActive)
        {
            earthTransform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }

    }
}
