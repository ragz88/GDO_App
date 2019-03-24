using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colourchanger : MonoBehaviour
{
    public Color red;
    public Color green;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.duckTheme)
        {
            this.GetComponent<SpriteRenderer>().color = green;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().color= red;
        }
    }
}
