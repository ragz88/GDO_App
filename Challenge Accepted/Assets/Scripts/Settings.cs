using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
    public Button dummyBut;
    public Dropdown nameList;
    public Dropdown challengeList;
    public Button themeBut;

    public Sprite tickedBox;
    public Sprite untickedBox;

    private void Start()
    {
        resetDropDown();
    }

    public void setDummyTrue()
    {
        GameManager.instance.dummyTeam = true;
        dummyBut.onClick.AddListener(setDummyFalse);
        dummyBut.onClick.RemoveListener(setDummyTrue);
        dummyBut.image.sprite = tickedBox;
    }

    public void setDummyFalse()
    {
        GameManager.instance.dummyTeam = false;
        dummyBut.onClick.AddListener(setDummyTrue);
        dummyBut.onClick.RemoveListener(setDummyFalse);
        dummyBut.image.sprite = untickedBox;
    }

    public void setThemeDuck()
    {
        //GameManager.instance.duckTheme = true;
        themeBut.onClick.AddListener(setThemeCock);
        themeBut.onClick.RemoveListener(setThemeDuck);
        themeBut.image.sprite = tickedBox;
    }

    public void setThemeCock()
    {
        //GameManager.instance.duckTheme = false;
        themeBut.onClick.AddListener(setThemeDuck);
        themeBut.onClick.RemoveListener(setThemeCock);
        themeBut.image.sprite = untickedBox;
    }

    public void EliminatePlayer()
    {
        string[] tempNameArray = new string[GameManager.instance.cockNames.Length - 1];
        int count = 0;
        for (int i = 0; i < GameManager.instance.cockNames.Length; i++)
        {
            if (GameManager.instance.cockNames[i] != nameList.captionText.text)
            {
                tempNameArray[count] = GameManager.instance.cockNames[i];
                count++;
            }
        }

        GameManager.instance.cockNames = tempNameArray;
        resetDropDown();
    }

    void resetDropDown()
    {
        nameList.ClearOptions();
        Dropdown.OptionData[] newData = new Dropdown.OptionData[5];
        for (int i = 0; i < GameManager.instance.cockNames.Length; i++)
        {
            newData[i] = new Dropdown.OptionData();
            newData[i].text = GameManager.instance.cockNames[i];
            nameList.options.Add(newData[i]);
        }
    }

    public void backButton()
    {
        switch (challengeList.value)
        {
            case 0:
                GameManager.instance.currentPage = GameManager.CurrentPage.Chal1;
                SceneManager.LoadScene("Event_1");
                break;
            case 1:
                GameManager.instance.currentPage = GameManager.CurrentPage.Chal2;
                SceneManager.LoadScene("Event_2");
                break;
            case 2:
                GameManager.instance.currentPage = GameManager.CurrentPage.Chal3;
                SceneManager.LoadScene("Event_3");
                break;
            case 3:
                GameManager.instance.currentPage = GameManager.CurrentPage.Elimination;
                SceneManager.LoadScene("Eliminations");
                break;

        }
    }
}
