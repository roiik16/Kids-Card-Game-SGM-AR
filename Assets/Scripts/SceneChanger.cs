using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour {

    public Button StartButton, HowToButton;
    public GameObject HowTocanvas;


    // Use this for initialization
    void Start()
    {
        Button btn1 = StartButton.GetComponent<Button>();
        Button btn2 = HowToButton.GetComponent<Button>();

        StartButton.onClick.AddListener(StartGame);
        HowToButton.onClick.AddListener(HowTo);
    }
	
	// Update is called once per frame
	void Update ()
    {
       
    }

    void StartGame()
    {
        Debug.Log("Startgame clicked");
        SceneManager.LoadScene("Interactive number learning");
    }

    void HowTo()
    {
        Debug.Log("HWTO clicked");
        HowTocanvas.SetActive(true);
    }

}
