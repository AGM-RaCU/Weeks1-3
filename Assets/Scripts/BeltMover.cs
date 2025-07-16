using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltMover : MonoBehaviour
{
    bool MachineOn = false; //Bool binary to change state between moving or not

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //mouse press turns bool true to begin functionality
        {
            MachineOn = true; //"the machine turns on"; belt starts moving
        }

        if (MachineOn) //Functionality starts when bool is true
        {

            Vector3 beltPosition = transform.position + Vector3.right * 0.01f; //vector3 defining how the belt will move to the right

            transform.position = beltPosition; //applies vector3 to belt's transform position, belt moves

        }
        

    }
}
