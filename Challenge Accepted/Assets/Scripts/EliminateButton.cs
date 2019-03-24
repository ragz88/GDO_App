using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EliminateButton : MonoBehaviour
{

    public Text buttText;
    public string buttCaption;
    public int buttonNumber;
    public EliminationController elimHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        buttText.text = buttCaption;
    }

    public void updateElimString()
    {
        //EliminationController elimHand = GameObject.Find("ElimHandler").GetComponent<EliminationController>();
        elimHand.elimineeName = buttText.text;
        //elimHand.selectedButton = buttonNumber;
        
    }
}
