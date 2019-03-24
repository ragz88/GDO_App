﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationToggle : MonoBehaviour
{
    [SerializeField]
    Sprite locationActiveRed;
    Sprite locationActiveGreen;
    Sprite locationInactive;
    bool isActive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetLocationActive ()
    {
        
        if(!isActive)
        {
           if (GameManager.instance.duckTheme)
           {
               this.GetComponent<Image>().sprite = locationActiveGreen;
           }
           else
           {
            this.GetComponent<Image>().sprite = locationActiveRed;
           }
            isActive = true;
        }
        else
        {
            {
                this.GetComponent<Image>().sprite = locationInactive;
            }
            isActive = false;
        }
    

    }


}
