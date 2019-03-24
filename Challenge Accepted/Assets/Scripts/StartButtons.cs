using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtons : MonoBehaviour
{

    public GameObject[] thingsToActivate;
    public ScoreSimulation scoreFixer;
    public Camera ARCam;

    public enum EventType
    {
        Event_1,
        Event_2
    }

    public EventType eventType = EventType.Event_1;

    // Start is called before the first frame update
    void Start()
    {
        ARCam.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startEvent()
    {
        for (int i = 0; i < thingsToActivate.Length; i++)
        {
            thingsToActivate[i].SetActive(true);
        }
        
        if (eventType == EventType.Event_1)
        {
            scoreFixer.startTiming = true;
        }

        gameObject.SetActive(false);
    }
}
