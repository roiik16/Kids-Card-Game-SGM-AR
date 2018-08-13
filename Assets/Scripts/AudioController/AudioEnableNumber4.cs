using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AudioEnableNumber4 : MonoBehaviour, IVirtualButtonEventHandler
{

    public AudioSource Fourplayback;
    public GameObject AudioBtn;

    void Start()
    {
        AudioBtn = GameObject.Find("Audiobtn4");
        AudioBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        Fourplayback = GetComponent<AudioSource>();



    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        Debug.Log("Audio Button pressed");
        Fourplayback.Play(1);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Audio Button released");
    }
}
