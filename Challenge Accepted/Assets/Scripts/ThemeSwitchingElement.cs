using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThemeSwitchingElement : MonoBehaviour
{
    public Sprite green;
    public Sprite red;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.duckTheme)
        {
            this.GetComponent<SpriteRenderer>().sprite = green;
        }
        else
        {
            this.GetComponent<SpriteRenderer>().sprite = red;
        }

    }
}
