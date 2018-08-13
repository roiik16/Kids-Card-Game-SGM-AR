using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AudioEnable : MonoBehaviour, IVirtualButtonEventHandler
{
    public AudioSource Twoplayback;
    public GameObject AudioBtn;

    void Start()
    {
        AudioBtn = GameObject.Find("Audiobtn2");
        AudioBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        Twoplayback = GetComponent<AudioSource>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Audio Button pressed");
        Twoplayback.Play(1);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Audio Button released");
    }
}
