using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TimedUpdate : MonoBehaviour
{
    public Sprite[] clues;
    int counter = 0 ;
    public float minutes;
    float seconds;
    float timepassed = 0;
    public bool startTiming = false;
    // Start is called before the first frame update
    void Start()
    {
        seconds = minutes * 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTiming)
        {
            timepassed += Time.deltaTime;
            print("Im timing");
        }
        

        if(timepassed > seconds)
        {
            timepassed = 0;
            counter++;
        }

        if(counter == clues.Length)
        {
            counter = 0;
        }

        this.GetComponent<SpriteRenderer>().sprite = clues[counter];
    }
}
