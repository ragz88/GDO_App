using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenCloseScanner : MonoBehaviour
{

    public Button scanBut;
    public Camera ARCam;
    // Start is called before the first frame update
    void Start()
    {
        MinCam();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MinCam()
    {
        //ARCam.rect = new Rect(new Vector2(0.1f, 0.1f), new Vector2(0.1f, 0.1f));
        ARCam.enabled = false;
        scanBut.onClick.AddListener(MaxCam);
        scanBut.onClick.RemoveListener(MinCam);
    }

    public void MaxCam()
    {
        //ARCam.rect = new Rect(new Vector2(0.1f, 0.26f), new Vector2(0.8f, 0.6f));
        ARCam.enabled = true;
        scanBut.onClick.RemoveListener(MaxCam);
        scanBut.onClick.AddListener(MinCam);
    }
}
