using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool dummyTeam = false;

    public bool[] redTeamNodes;
    public bool[] blueTeamNodes;

    enum CurrentPage
    {
        Chal1,
        Chal2,
        Chal3,
        Elimination,
        Settings
    }

    CurrentPage currentPage = CurrentPage.Settings;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
