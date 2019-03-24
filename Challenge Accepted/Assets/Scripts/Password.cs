using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Password : MonoBehaviour
{

    public int passcode = 1975;
    public InputField field;

    public GameObject[] lockObjects;
    public GameObject[] objectsToHide;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < objectsToHide.Length; i++)
        {
            objectsToHide[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (field.text == passcode.ToString())
        {
            for (int i = 0; i < objectsToHide.Length; i++)
            {
                objectsToHide[i].SetActive(true);
            }

            for (int i = 0; i < lockObjects.Length; i++)
            {
                lockObjects[i].SetActive(false);
            }
        }
    }
}
