using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookMover : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 bookPosition = transform.position + Vector3.right * 0.01f;

        transform.position = bookPosition;


    }
}
