using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AudioEnableNumber5 : MonoBehaviour, IVirtualButtonEventHandler
{

    public AudioSource Fiveplayback;
    public GameObject AudioBtn;

    void Start()
    {
        AudioBtn = GameObject.Find("Audiobtn5");
        AudioBtn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        Fiveplayback = GetComponent<AudioSource>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Audio Button pressed");
        Fiveplayback.Play(1);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Audio Button released");
    }
}
