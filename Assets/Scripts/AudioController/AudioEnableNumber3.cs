using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AudioEnableNumber3 : MonoBehaviour, IVirtualButtonEventHandler
{

    public AudioSource Threeplayback;
    public GameObject AudioBtn;

    void Start()
    {
        AudioBtn = GameObject.Find("Audiobtn3");
        AudioBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        Threeplayback = GetComponent<AudioSource>();



    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {

        Debug.Log("Audio Button pressed");
        Threeplayback.Play(1);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Audio Button released");
    }
}
