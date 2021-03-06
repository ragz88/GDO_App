﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool dummyTeam = false;
    public bool duckTheme = false;

    public bool[] redTeamNodes;
    public bool[] blueTeamNodes;
   
    public string[] cockNames;

    public enum CurrentPage
    {
        Chal1,
        Chal2,
        Chal3,
        Elimination
    }

    public CurrentPage currentPage = CurrentPage.Chal1;

    public int challenge1CockScore = 0;
    public int challenge1DuckScore = 0;

    public static GameManager instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.

    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);


        DontDestroyOnLoad(gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        redTeamNodes  = new bool[5];
        blueTeamNodes = new bool[5];

        cockNames = new string[5];
        cockNames[0] = "Hanli";
        cockNames[1] = "Kieran";
        cockNames[2] = "Kirsten";
        cockNames[3] = "Luke";
        cockNames[4] = "Siya";
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
