using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookShredding : MonoBehaviour
{
    SpriteRenderer bookSprite; //book prefab spriterenderer

    public Sprite shreddedPaper, wastedPaper; //shredded and wasted paper sprites

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bookSprite = GetComponent<SpriteRenderer>(); //access the spriterenderer and set book sprite variable

        if (transform.position.x > 5) //check for book's location
        {
            if (Input.GetMouseButton(0)) //check for left mouse input
            {
                bookSprite.sprite = shreddedPaper; //change book sprite to shredded paper sprite 
            }
        }

        if (transform.position.x > 8) //check for book's location
        {
            if (Input.GetMouseButton(0)) //check for left mouse input
            {
                bookSprite.sprite = wastedPaper; //change book sprite to wasted paper sprite
            }
        }
    }
}
