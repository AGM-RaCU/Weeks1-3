using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookChanger : MonoBehaviour
{
    public Slider bookChangerSlider; //slider to change book sprite

    public SpriteRenderer bookSprite; //book prefab spriterenderer

    public Sprite book1sprite, book2sprite, book3sprite; //book sprites

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bookChangerSlider.value == 0) //on first value of the slider
        {
            bookSprite.sprite = book1sprite; //use first book sprite
        }

        if (bookChangerSlider.value == 1) //on second value of the slider
        {
            bookSprite.sprite = book2sprite; //use second book sprite
        }

        if (bookChangerSlider.value == 2) //on third value of the slider
        {
            bookSprite.sprite = book3sprite; //use third book sprite
        }
    }
}
