using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Button9Controller : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject EnableTally;
    public GameObject vbBtnObj;
    public Animator cubeAni;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("TallyBtn9");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        cubeAni.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        EnableTally.SetActive(true);
        cubeAni.Play("9Tallyanim");
        Debug.Log("Tally Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Tally Button released");
    }
}
