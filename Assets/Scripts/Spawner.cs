using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.Timeline;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public Vector3 spawnPoint;
    public int framerate;
    List<GameObject> spawnedObjects = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = framerate;
       //spawnedObjects { }

       //GameObject spawnedObject = Instantiate(prefabToSpawn);
       //spawnedObjects.Add(spawnedObject);

       //spawnedObjects { spawnedObject[0] }

       //GameObject spawnedObject2 = Instantiate(prefabToSpawn, spawnPoint, Quaternion.identity);
       //spawnedObjects.Add(spawnedObject2);

       //spawnedObjects { spawnedObject[0], spawnedObject2[1] }

       //DONT DO THIS!!!!!!
       //Destroy(prefabToSpawn);
       //
      
       //Destroy(spawnedObjects[0]);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject spawnedObject = Instantiate(prefabToSpawn);
            spawnedObjects.Add(spawnedObject);
            //spawnedObjects.Add(Instantiate(spawnedObject));
        }

        if (Input.GetMouseButtonDown(1))
        {
            for(int i = 0; i < spawnedObjects.Count; i++)
            {
                Destroy(spawnedObjects[i]);
            }

            //foreach(GameObject spawnedObject in spawnedObjects)
            //{
            //Destroy(spawnedObject);
            //}

            spawnedObjects.Clear();
        }
    }
}
