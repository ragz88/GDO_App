using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSwitcher : MonoBehaviour
{
    public Sprite button1r;
    public Sprite button2r;
    public Sprite button1g;
    public Sprite button2g;
    bool buttonOne = true;
    public bool isStatsButton = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwapButtons ()
    {
        if(GameManager.instance.duckTheme)
        {
            if (buttonOne)
            {
                this.GetComponent<Image>().sprite = button2g;
                buttonOne = false;
            }
            else
            {
                this.GetComponent<Image>().sprite = button1g;
                buttonOne = true;
            }
        }
        else
        {
            if (buttonOne)
            {
                this.GetComponent<Image>().sprite = button2r;
                buttonOne = false;
            }
            else
            {
                this.GetComponent<Image>().sprite = button1r;
                buttonOne = true;
            }
        }

        if(isStatsButton)
        {
            if(buttonOne)
            {
                //show picture and hints 
            }
        }

    }

}
