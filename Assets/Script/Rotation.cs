using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        float xAxis = Input.GetAxis("Vertical");
        float yAxis = Input.GetAxis("Horizontal");
        transform.Rotate(xAxis, 0, yAxis,Space.Self);
    }
}
