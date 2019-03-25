using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintUpdater : MonoBehaviour
{
    public Sprite[] greenHints;
    public Sprite[] redHints;
    //public Sprite originHintPic;
    public GameObject origHint;

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
            origHint.SetActive(false);
            if (GameManager.instance.duckTheme)
            {
                this.GetComponent<SpriteRenderer>().sprite = greenHints[GameManager.instance.challenge1CockScore];
            }
            else
            {
                this.GetComponent<SpriteRenderer>().sprite = redHints[GameManager.instance.challenge1CockScore];
            }
        }
        else
        {
            if (GameManager.instance.challenge1CockScore < 4)
            {
                this.GetComponent<SpriteRenderer>().enabled = false;
                origHint.SetActive(true);
            }
            else
            {
                this.GetComponent<SpriteRenderer>().enabled = true;
                origHint.SetActive(false);
                if (GameManager.instance.duckTheme)
                {
                    this.GetComponent<SpriteRenderer>().sprite = greenHints[GameManager.instance.challenge1CockScore];
                }
                else
                {
                    this.GetComponent<SpriteRenderer>().sprite = redHints[GameManager.instance.challenge1CockScore];
                }
            }
        }
    }
}
