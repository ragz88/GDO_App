using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EliminationController : MonoBehaviour
{
    public Text bigElimTxt;
    public Text medElimTxt;
    public string elimineeName = "";
    public GameObject finalBackButton;
    public GameObject medBackButton;
    public GameObject confirmButton;

    public Transform[] buttPoints;

    //public int selectedButton = 0;

    GameObject[] buttons;

    public GameObject buttPrefab;

    // Start is called before the first frame update
    void Start()
    {
        buttons = new GameObject[5];

        for (int i = 0; i < GameManager.instance.cockNames.Length; i++)
        {
            GameObject currentButt = Instantiate(buttPrefab, buttPoints[i].transform.position, Quaternion.identity, buttPoints[i]) as GameObject;
            currentButt.GetComponent<EliminateButton>().elimHand = this;
            currentButt.GetComponent<EliminateButton>().buttCaption = GameManager.instance.cockNames[i];
            currentButt.GetComponent<Button>().onClick.AddListener(EliminatePlayer);
            //currentButt.GetComponent<EliminateButton>().buttonNumber = i;
            buttons[i] = currentButt;
        }

       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EliminatePlayer()
    {
        for (int i = 0; i < GameManager.instance.cockNames.Length; i++)
        {
            buttons[i].SetActive(false);
        }
        medElimTxt.text = elimineeName;
        bigElimTxt.text = elimineeName;
        medElimTxt.gameObject.SetActive(true);
        medBackButton.SetActive(true);
        confirmButton.SetActive(true);
    }

    public void rethink()
    {
        for (int i = 0; i < GameManager.instance.cockNames.Length; i++)
        {
            buttons[i].SetActive(true);
        }
        medElimTxt.gameObject.SetActive(false);
        medBackButton.SetActive(false);
        confirmButton.SetActive(false);
    }

    public void confirmElimination()
    {
        medElimTxt.gameObject.SetActive(false);
        medBackButton.SetActive(false);
        confirmButton.SetActive(false);
        bigElimTxt.gameObject.SetActive(true);
        finalBackButton.SetActive(true);
    }

    public void finalBack()
    {
        SceneManager.LoadScene("Eliminations");
    }

}
