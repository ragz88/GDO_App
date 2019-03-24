using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageColourChanger : MonoBehaviour
{

    public enum ColourChangingType
    {
        Image,
        Text
    }

    public ColourChangingType ChangerType = ColourChangingType.Image;

    public Color red;
    public Color green;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ChangerType == ColourChangingType.Image)
        {
            if (GameManager.instance.duckTheme)
            {
                this.GetComponent<Image>().color = green;
            }
            else
            {
                this.GetComponent<Image>().color = red;
            }
        }
        else if (ChangerType == ColourChangingType.Text)
        {
            if (GameManager.instance.duckTheme)
            {
                this.GetComponent<Text>().color = green;
            }
            else
            {
                this.GetComponent<Text>().color = red;
            }
        }
    }
}
