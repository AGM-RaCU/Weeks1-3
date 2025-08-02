using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookSpawner : MonoBehaviour
{
    public GameObject bookPrefab; //book prefab to spawn

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonOn()
    {
        Instantiate(bookPrefab); //instantiate a clone of the book prefab
    }
}
