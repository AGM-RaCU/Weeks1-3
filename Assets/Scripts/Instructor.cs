using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructor : MonoBehaviour
{
        public float startValue;
        public float endValue;
    
        public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //base syntax

        //float startValue;
        //float endValue;
        //float currentTime;

        //float output = Mathf.Lerp(startValue, endValue, currentTime);

        float output = Mathf.Lerp(startValue, endValue, currentTime);

        //If currentTime = 0: Lerp will give us startValue
            //In this case 100

        //If currentTime = 0.25: Lerp will give us a quarter point from startValue to endValue
            //In this case 75

        //If currentTime = 0.5: Lerp will give us the halfway point between startValue and endValue
            //In this case 50

        //If currentTime = 0.75: Lerp will give us a point three-quarters from startValue to endValue
            //In this case 25

        //If currentTime = 1: Lerp will give us endValue
            //In this case 0

        Debug.Log(output.ToString());
    }
}
