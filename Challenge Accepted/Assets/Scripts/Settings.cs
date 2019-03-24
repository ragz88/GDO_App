using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{


    void setDummyTrue()
    {
        GameManager.instance.dummyTeam = true;
    }

    void setDummyFalse()
    {
        GameManager.instance.dummyTeam = false;
    }
}
