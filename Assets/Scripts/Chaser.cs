using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Vector3 newPosition;
    public Camera gameCamera;
    public float speed;
    Vector3 lastClickedPosition = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 mousePositionInWorldSpace = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        //mousePositionInWorldSpace.z = 0f;

        //Vector3 start = transform.position;
        //Vector3 target = mousePositionInWorldSpace;
        //Vector3 directionToMove = target - start;

        //transform.position = transform.position + directionToMove * speed;

        

        Vector3 mousePositionInWorldSpace = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePositionInWorldSpace.z = 0f;

        if (Input.GetMouseButtonDown(0)) //doublechecked syntax at https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Input.GetMouseButtonDown.html
        {
            lastClickedPosition = mousePositionInWorldSpace;

        }

        Vector3 start = transform.position;
        Vector3 target = lastClickedPosition;
        Vector3 directionToMove = target - start;

        transform.position = transform.position + directionToMove * speed;

    }
}
