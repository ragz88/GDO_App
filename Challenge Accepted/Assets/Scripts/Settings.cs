using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Button dummyBut;
    public Dropdown nameList;

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
        dummyBut.onClick.AddListener(setDummyFalse);
        dummyBut.onClick.RemoveListener(setDummyTrue);
        dummyBut.image.sprite = untickedBox;
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
}
