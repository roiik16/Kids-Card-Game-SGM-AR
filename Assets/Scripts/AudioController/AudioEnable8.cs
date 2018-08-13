using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class AudioEnable8 : MonoBehaviour, IVirtualButtonEventHandler
{

    public AudioSource Eightplayback;
    public GameObject AudioBtn;

    void Start()
    {
        AudioBtn = GameObject.Find("Audiobtn8");
        AudioBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        Eightplayback = GetComponent<AudioSource>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Audio Button pressed");
        Eightplayback.Play(1);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Audio Button released");
    }
}
