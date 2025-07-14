using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleColorChanger : MonoBehaviour
{
    public Camera gameCamera;
    public SpriteRenderer circleRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 mousePosition = gameCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f;

        Debug.Log(mousePosition.ToString());


        if (mousePosition.x == transform.position.x)
        {
            circleRenderer.color = Color.red;
        }

        if (mousePosition.y == transform.position.y)
        {
            circleRenderer.color = Color.red;
        }

    }
}
