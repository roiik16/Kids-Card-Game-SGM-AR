using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Start_AR : MonoBehaviour {

    public Button m_YourFirstButton;
    public GameObject tur;

    // Use this for initialization
    void Start ()
    {
        Button StartGame = m_YourFirstButton.GetComponent<Button>();
        StartGame.onClick.AddListener(TaskOnClick);
    }
	
	// Update is called once per frame
	void Update ()
    {
       
    }

    void TaskOnClick()
    {
        Debug.Log("Game started");
        tur.SetActive(false);
    }
}
