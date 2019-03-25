using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picturechanger : MonoBehaviour
{
    public Sprite[] pictures;
    public GameObject originPic;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.instance.dummyTeam)
        {
            this.GetComponent<SpriteRenderer>().enabled = true;
            originPic.SetActive(false);
            this.GetComponent<SpriteRenderer>().sprite = pictures[GameManager.instance.challenge1CockScore];
        }
        else
        {
            if (GameManager.instance.challenge1CockScore < 4)
            {
                this.GetComponent<SpriteRenderer>().enabled = false ;
                originPic.SetActive(true);
            }
            else
            {
                this.GetComponent<SpriteRenderer>().sprite = pictures[GameManager.instance.challenge1CockScore];
                this.GetComponent<SpriteRenderer>().enabled = true;
                originPic.SetActive(false);
            }
        }
    }
}
