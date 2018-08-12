using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AudioEnableNumber1 : MonoBehaviour, IVirtualButtonEventHandler
{
    public AudioSource Oneplayback;
    public GameObject AudioBtn;

    void Start()
    {
        AudioBtn = GameObject.Find("Audiobtn1");
        AudioBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        Oneplayback = GetComponent<AudioSource>();



    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        Debug.Log("Audio Button pressed");
        Oneplayback.Play(1);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Audio Button released");
    }
}
