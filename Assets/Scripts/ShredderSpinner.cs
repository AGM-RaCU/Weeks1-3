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
        Vector3 bladeSpin = transform.eulerAngles;
        bladeSpin.z += 1f;
        transform.eulerAngles = bladeSpin;
    }
}
