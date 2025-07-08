using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Vector3 newPosition;
    public Camera gameCamera;
    public SpriteRenderer chaserRenderer;

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

        if (Input.GetMouseButtonDown(0)) 
        {
            lastClickedPosition = mousePositionInWorldSpace;

        }

        Vector3 start = transform.position;
        Vector3 target = lastClickedPosition;
        Vector3 directionToMove = target - start;

        transform.position = transform.position + directionToMove * speed;

        Vector3 chaserPositionInScreenSpace = gameCamera.WorldToScreenPoint(transform.position);

        //Debug.Log("ChaserPosition in ScreenSpace = " + chaserPositionInScreenSpace.ToString());

        float xMin = 0f;
        float yMin = 0f;
        float xMax = Screen.width;
        float yMax = Screen.height;

        //if chaser's x value is less than xMin
        //if chaser's x value is more than xMax
        //if chaser's y value is less than yMin
        //if chaser's y value is more than yMax
        //THEN:
        //change the color of the sprite to be red

        //bool xMaxExceeded = if the chaser position goes beyond the right of the screen
        //bool xMinExceeded = if the chaser position goes beyond the left of the screen

        bool xMaxExceeded = chaserPositionInScreenSpace.x >= xMax;
        bool xMinExceeded = chaserPositionInScreenSpace.x <= xMin;
        bool yMaxExceeded = chaserPositionInScreenSpace.y >= yMax;
        bool yMinExceeded = chaserPositionInScreenSpace.y <= yMin;

        Debug.Log("xMaxExceeded = " + xMaxExceeded.ToString());
        Debug.Log("xMinExceeded = " + xMinExceeded.ToString());
        Debug.Log("yMaxExceeded = " + yMaxExceeded.ToString());
        Debug.Log("yMinExceeded = " + yMinExceeded.ToString());

        Debug.Log("x " + chaserPositionInScreenSpace.x.ToString());
        Debug.Log("y " + chaserPositionInScreenSpace.y.ToString());

        if (xMaxExceeded || xMinExceeded || yMaxExceeded || yMinExceeded)
        {
            //Change the color of the sprite
            chaserRenderer.color = Color.red;
        }
        else
        {
            chaserRenderer.color = Color.white;
        }
    }
}
