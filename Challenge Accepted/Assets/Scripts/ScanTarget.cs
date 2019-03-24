using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanTarget : MonoBehaviour
{
    MeshRenderer rend;
    public int targetNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, 2f, 0);
        if (rend.enabled == true)
        {
            if (targetNumber > GameManager.instance.challenge1CockScore)
            {
                GameManager.instance.challenge1CockScore = targetNumber;
            }
        }
        print(GameManager.instance.challenge1CockScore);
    }
}
