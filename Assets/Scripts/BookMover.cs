using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Events;

public class BookMover : MonoBehaviour
{

    //public bool MachineOn = false; //Bool binary to change state between moving or not
    //public UnityEvent buttonPressed;

    // Start is called before the first frame update
    void Start()
    {
        //buttonOn();
    }

    // Update is called once per frame
    void Update()
    {

        //buttonOn();

        //if (MachineOn) //Functionality starts when bool is true
        //{
            Vector3 bookPosition = transform.position + Vector3.right * 0.01f; //vector3 defining how the book will move to the right

            transform.position = bookPosition; //applies vector3 to book's transform position, book moves

            if (transform.position.x > 7) //check for book's location
            {
                Destroy(gameObject); //destroy the book game object when passing through shredder
            }


        //}

    }

    //public void buttonOn() //button press turns bool true to begin functionality
    //{
        //MachineOn = true; //"the machine turns on"; belt pulls book
        //Debug.Log("button works");
        //buttonPressed.Invoke();
        //Debug.Log("event called");
        //Vector3 bookPosition = transform.position + Vector3.right * 0.01f; //vector3 defining how the book will move to the right
        //transform.position = bookPosition;
        //Debug.Log("literallywhat");

    //}
}
