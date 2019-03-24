using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class picturechanger : MonoBehaviour
{
    public Sprite[] pictures;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<SpriteRenderer>().sprite = pictures[GameManager.instance.challenge1CockScore];
    }
}
