using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookShredding : MonoBehaviour
{
    SpriteRenderer bookSprite;

    public Sprite shreddedPaper, wastedPaper;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bookSprite = GetComponent<SpriteRenderer>();

        if (transform.position.x > 5) //check for book's location
        {
            if (Input.GetMouseButton(1))
            {
                bookSprite.sprite = shreddedPaper; //destroy the book game object when passing through shredder
            }
        }

        if (transform.position.x > 8) //check for book's location
        {
            if (Input.GetMouseButton(1))
            {
                bookSprite.sprite = wastedPaper; //destroy the book game object when passing through shredder
            }
        }
    }
}
