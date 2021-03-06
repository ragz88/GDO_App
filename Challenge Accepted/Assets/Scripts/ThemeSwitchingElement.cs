﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThemeSwitchingElement : MonoBehaviour
{
    public Sprite green;
    public Sprite red;
    public Sprite green2;
    public Sprite red2;
    public bool isButton = false;
    public bool isHeading = false;
    // Start is called before the first frame update
    void Start()
    {
         if(isButton)
        {
            if (GameManager.instance.duckTheme)
            {
                this.GetComponent<Image>().sprite = green;
            }
            else
            {
                this.GetComponent<Image>().sprite = red;
            }
        }
        else
        {
            if (GameManager.instance.duckTheme)
            {
                this.GetComponent<SpriteRenderer>().sprite = green;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().sprite = red;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
      if(isHeading && (GameManager.instance.challenge1CockScore > 4))
      {
            if (GameManager.instance.duckTheme)
            {
                this.GetComponent<SpriteRenderer>().sprite = green2;
            }
            else
            {
                this.GetComponent<SpriteRenderer>().sprite = red2;
            }
      }

    }
}
