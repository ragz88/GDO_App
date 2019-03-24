using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.duckTheme)
        {
            this.GetComponent<Camera>().backgroundColor = Color.black;
        }
        else
        {
            this.GetComponent<Camera>().backgroundColor = Color.white;
        }
    }
}
