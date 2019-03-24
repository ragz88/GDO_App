using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Event3_Controller : MonoBehaviour
{

    public GameObject startButton;
    public GameObject stopText;
    public GameObject statText;
    public Image timerCircle;
    public Text cockScoreTxt;
    public Text duckScoreTxt;
    public GameObject cockScoreLabel;
    //public GameObject duckScoreLabel;
    public Text winLoseTxt;
    public GameObject incButton;

    public InputField passwordField;
    public string password = "ProbsDueToSiya";

    bool countingDown = false;
    bool timeUp = false;

    float currentValue = 180;//180 = 3 minutes  //time in seconds
    float initialValue;

    int cockScore = 0;
    //int duckScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        initialValue = currentValue;
    }

    // Update is called once per frame
    void Update()
    {
        if (countingDown)
        {
            currentValue -= Time.deltaTime;
            timerCircle.fillAmount = currentValue / initialValue;
            if (currentValue < 0.1f)
            {
                timeUp = true;
                countingDown = false;
                passwordField.gameObject.SetActive(true);
            }
        }

        if (timeUp)
        {
            
            stopText.SetActive(true);
            
            passwordField.gameObject.SetActive(true);
            incButton.SetActive(false);

            if (cockScore + 2 < 20)
            {
                duckScoreTxt.text = (cockScore + 2).ToString();
            }
            else if (cockScore + 1 < 20)
            {
                duckScoreTxt.text = (cockScore + 1).ToString();
            }
            else
            {
                duckScoreTxt.text = (cockScore).ToString();
            }

            if (cockScore >= 20)
            {
                winLoseTxt.text = "DRAW!";
            }
            else
            {
                winLoseTxt.text = "LOSS!";
            }

            if (passwordField.text == password)
            {
                statText.SetActive(true);
                passwordField.gameObject.SetActive(false);
            }
            
        }
    }

    public void startEvent()
    {
        countingDown = true;
        incButton.SetActive(true);
        cockScoreTxt.gameObject.SetActive(true);
        cockScoreLabel.SetActive(true);
        startButton.SetActive(false);
    }

    public void incScore()
    {
        cockScore++;
        cockScoreTxt.text = cockScore.ToString();
    }
}
