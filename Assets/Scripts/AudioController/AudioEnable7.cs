using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AudioEnable7 : MonoBehaviour, IVirtualButtonEventHandler
{

    public AudioSource Sevenplayback;
    public GameObject AudioBtn;

    void Start()
    {
        AudioBtn = GameObject.Find("Audiobtn7");
        AudioBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        Sevenplayback = GetComponent<AudioSource>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Audio Button pressed");
        Sevenplayback.Play(1);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Audio Button released");
    }
}
