using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changer : MonoBehaviour
{
    //1. Create a class float variable called timer.
    //2. After 3 seconds have passed – change the colour of the object to green.
    //3. After 4 seconds have passed – change the size of the object to be twice as large.
    //4. After 5 seconds have passed – rotate the object by 180 degrees.
    //5. After 6 seconds have passed – destroy the object.
    
    float timer = 0f;
    public SpriteRenderer changerRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 3)
        {
            changerRenderer.color = Color.green;
        }
        if (timer > 4)
        {
            //transform.localScale = transform.localScale * 1.2f;
        }
        if (timer > 5)
        {
            //eulerAngles
        }
        if (timer > 6)
        {
            //Destroy();
        }
    }
}
