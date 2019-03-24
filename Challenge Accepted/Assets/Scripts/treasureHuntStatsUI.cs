using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureHuntStatsUI : MonoBehaviour
{
    public int blipNumber;
    public bool isDuck = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(isDuck)
        {
            if (GameManager.instance.challenge1DuckScore >= blipNumber)
            {
                GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                GetComponent<SpriteRenderer>().enabled = false;
            }
        }
      else
        {
            if (GameManager.instance.challenge1CockScore >= blipNumber)
            {
                GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }
}
