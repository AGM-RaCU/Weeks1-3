using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMover : MonoBehaviour
{

    //Class variables go here:
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //Vector3: x(0), y(0), z(0)
        //Type nameOfVariable =
        //Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Vector3 newPosition = transform.position + Vector3.right * 1;
        
        transform.position = newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
