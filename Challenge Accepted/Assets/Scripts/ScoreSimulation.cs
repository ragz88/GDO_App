using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSimulation : MonoBehaviour
{

    public bool startTiming = false;
    float currentTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startTiming)
        {
            print(currentTime);

            currentTime += Time.deltaTime;
            if (currentTime > 60 && GameManager.instance.challenge1DuckScore < 1)
            {
                GameManager.instance.challenge1DuckScore = 1;
            }

            if (currentTime > 180 && GameManager.instance.challenge1DuckScore < 2)
            {
                GameManager.instance.challenge1DuckScore = 2;
            }

            if (currentTime > 510 && GameManager.instance.challenge1CockScore < 3)
            {
                startTiming = false;
            }

            if (currentTime < 509 && GameManager.instance.challenge1CockScore >= 3)
            {
                currentTime = 510;
            }

            if (currentTime > 540 && GameManager.instance.challenge1DuckScore < 3)
            {
                GameManager.instance.challenge1DuckScore = 3;
            }

            if (currentTime > 850 && GameManager.instance.challenge1DuckScore < 4)
            {
                GameManager.instance.challenge1DuckScore = 4;
            }

            if (currentTime > 1040 && GameManager.instance.challenge1CockScore < 4)
            {
                startTiming = false;
            }

            if (currentTime < 810 && GameManager.instance.challenge1CockScore >= 4 && GameManager.instance.challenge1DuckScore >= 3)
            {
                currentTime = 811;
            }

            if (currentTime < 1039 && GameManager.instance.challenge1CockScore >= 4 && GameManager.instance.challenge1DuckScore >= 4)
            {
                currentTime = 1040;
            }

            if (currentTime > 1100 && GameManager.instance.challenge1DuckScore < 5)
            {
                GameManager.instance.challenge1DuckScore = 5;
            }

        }
        else if (GameManager.instance.challenge1CockScore >= 3 && currentTime < 1000)
        {
            startTiming = true;
        }
        else if (GameManager.instance.challenge1CockScore >= 4)
        {
            startTiming = true;
        }
    }
}
