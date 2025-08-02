using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShredderSpinner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0)) //check for left mouse input
        {
        Vector3 bladeSpin = transform.eulerAngles; //Vector3 to define rotation
        bladeSpin.z += 5f; //rotation speed
        transform.eulerAngles = bladeSpin;   //rotate the saw blade 
        }
     
    }
}
