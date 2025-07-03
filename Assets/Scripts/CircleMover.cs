using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //bool ifEscape*IsPressed = Input.GetKeyDown(KeyCode.Escape);

        Vector3 newRightPosition = transform.position + Vector3.right * 0.5f;

        bool ifRightArrowIsPressed = Input.GetKey(KeyCode.RightArrow); //GetKey works as long as the key is pressed, stops when the key is no longer pressed
        
        if (ifRightArrowIsPressed)
        {
            transform.position = newRightPosition;
        }

        Vector3 newUpPosition = transform.position + Vector3.up * 0.1f;

        bool ifUpArrowIsPressed = Input.GetKeyUp(KeyCode.UpArrow); //GetKeyUp works the moment the key is no longer pressed, doesn't start at any point prior

        if (ifUpArrowIsPressed)
        {
            transform.position = newUpPosition;
        }

        Vector3 newDownPosition = transform.position + Vector3.down * 0.1f;

        bool ifDownArrowIsPressed = Input.GetKeyDown(KeyCode.DownArrow); //GetKeyDown works the moment the key is pressed, doesn't work at any point later, regardless of if the key is pressed or not

        if (ifDownArrowIsPressed)
        {
            transform.position = newDownPosition;
        }
    }
}
