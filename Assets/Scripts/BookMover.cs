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
            Vector3 bookPosition = transform.position + Vector3.right * 0.03f; //vector3 defining how the book will move to the right

            transform.position = bookPosition; //applies vector3 to book's transform position, book moves

            if (transform.position.x > 10) //check for book's location
            {
                Destroy(gameObject); //destroy the book game object when passing through shredder
            }

    }

}
