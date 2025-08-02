using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookChanger : MonoBehaviour
{
    public Slider bookChangerSlider;

    public SpriteRenderer bookSprite;

    public Sprite book1sprite, book2sprite, book3sprite;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bookChangerSlider.value == 0)
        {
            bookSprite.sprite = book1sprite;
        }

        if (bookChangerSlider.value == 1)
        {
            bookSprite.sprite = book2sprite;
        }

        if (bookChangerSlider.value == 2)
        {
            bookSprite.sprite = book3sprite;
        }
    }
}
