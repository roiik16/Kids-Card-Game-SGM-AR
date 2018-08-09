using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AudioEnable : MonoBehaviour, IVirtualButtonEventHandler
{

    public AudioSource OneAudio;
    public GameObject AudioBtn;

    // Use this for initialization
    void Start()
    {
        AudioBtn = GameObject.Find("Audiobtn");
        AudioBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
    
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Audio Button pressed");
        OneAudio.Play(0);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Audio Button released");
    }
}
