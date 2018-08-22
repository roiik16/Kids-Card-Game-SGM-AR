using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

//card CONTROLLER SCRIPT
//THIS SCRIPT MUST BE APPLIED TO ALL IMAGE TARGETS IN ORDER FOR EVERY TARGET TO WORK

[RequireComponent(typeof(AudioSource))]
public class GameController : MonoBehaviour, ITrackableEventHandler, IVirtualButtonEventHandler
{
    //ALL THE BELOW CODE IS USED TO DETECT TRACKING, PRINT AND CHECK.
    
    protected TrackableBehaviour mTrackableBehaviour;

    protected virtual void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);


        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        TallyAnim.GetComponent<Animator>();
        Numberaudio = GetComponent<AudioSource>();
    }

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }

    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            Debug.Log("Trackable card " + mTrackableBehaviour.TrackableName + " found");
            OnTrackingFound();

        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            Debug.Log("Trackable card " + mTrackableBehaviour.TrackableName + " lost");
            OnTrackingLost();
        }
    }
    public AudioSource Numberaudio;
    public GameObject vbBtnObj; //Virtual Button
    public Animator TallyAnim; //Tally animation
    
    //Booleans created to be able to detect multiple cards at once and play the corresponding audio.
    bool card01; bool card02; bool card03; bool card04; bool card05; bool card06; bool card07; bool card08; bool card09; bool card10;

    private void OnTrackingFound()
    {
        if (mTrackableBehaviour.TrackableName == "card01") //card1
        {
            card01 = true;
        }

        if (mTrackableBehaviour.TrackableName == "card02")
        {
            card02 = true;
           
        }
        
        if (mTrackableBehaviour.TrackableName == "card03") 
        {
            card03 = true;
            
        }

        if (mTrackableBehaviour.TrackableName == "card04") 
        {
            card04 = true;           
        }

        if (mTrackableBehaviour.TrackableName == "card05") 
        {
            card05 = true;          
        }

        if (mTrackableBehaviour.TrackableName == "card06") 
        {
            card06 = true;            
        }

        if (mTrackableBehaviour.TrackableName == "card07") 
        {
            card07 = true;         
        }

        if (mTrackableBehaviour.TrackableName == "card08") 
        {
            card08 = true;            
        }

        if (mTrackableBehaviour.TrackableName == "card09") 
        {
            card09 = true;          
        }

        if (mTrackableBehaviour.TrackableName == "card10") 
        {
            card10 = true;            
        }

        cardMatch();
    } //When Card is scanned
   
    public void cardMatch()
    {
        // Debug.Log("Checking for matches" + Drone + Fissure);
        if (card01 == true && card02 == true)
        {
            Debug.Log("Both True");
        }
    } //cardMatch - To detect if two cards have been found and play matched audio clip

    public void OnTrackingLost()
    {
        card01 = false; card02 = false; card03 = false; card04 = false; card05 = false; card06 = false; card07 = false; card08 = false; card09 = false; card10 = false; //Releasing boolean
        TallyAnim.Play("None");
    }

    bool WasPressed; //Bool virtual button detector
    bool animationreset; //Bool animation reset

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (mTrackableBehaviour.TrackableName == "card01" && vb.name == "vb1" && WasPressed == false) //Check what is the tracked name
        {
            Debug.Log("I Found your Attempt2 and button clicked!"); //Print info
            TallyAnim.Play("OneTallyAnim"); //Play tally anim
            Numberaudio.Play(); ; //Play Clip
            WasPressed = true; //Triggering the button pressed
            animationreset = true; //Animation reset
            StartCoroutine(DelayedMethod()); // DISABLING MULTIPLE PRESSES AT ONE GO (A MUST WITH VUFORIA VIRTUAL BUTTON DUE TO LIGHTING TRIGGERING IT)
     
        }

        if (mTrackableBehaviour.TrackableName == "card02" && vb.name == "vb1" && WasPressed == false)
        {
            TallyAnim.Play("TwoTally");
            Numberaudio.Play();
            WasPressed = true; //Triggering the button pressed
            StartCoroutine(DelayedMethod()); // DISABLING MULTIPLE PRESSES AT ONE GO (A MUST WITH VUFORIA VIRTUAL BUTTON DUE TO LIGHTING TRIGGERING IT)
        }

        if (mTrackableBehaviour.TrackableName == "card03" && vb.name == "vb1" && WasPressed == false)
        {
            Debug.Log("I Found your card03!");
            Numberaudio.Play();
            TallyAnim.Play("Threetallyanim");
            WasPressed = true; //Triggering the button pressed
            StartCoroutine(DelayedMethod()); // DISABLING MULTIPLE PRESSES AT ONE GO (A MUST WITH VUFORIA VIRTUAL BUTTON DUE TO LIGHTING TRIGGERING IT)
        }
        if (mTrackableBehaviour.TrackableName == "card04" && vb.name == "vb1" && WasPressed == false)
        {
            Debug.Log("I Found your card04!");
            Numberaudio.Play();
            WasPressed = true; //Triggering the button pressed
            TallyAnim.Play("4Tallyanim");
            StartCoroutine(DelayedMethod()); // DISABLING MULTIPLE PRESSES AT ONE GO (A MUST WITH VUFORIA VIRTUAL BUTTON DUE TO LIGHTING TRIGGERING IT)
        }
        if (mTrackableBehaviour.TrackableName == "card05" && vb.name == "vb1" && WasPressed == false)
        {
            Debug.Log("I Found your card05!");
            Numberaudio.Play();
            WasPressed = true; //Triggering the button pressed
            TallyAnim.Play("5tallyanim");
            StartCoroutine(DelayedMethod()); // DISABLING MULTIPLE PRESSES AT ONE GO (A MUST WITH VUFORIA VIRTUAL BUTTON DUE TO LIGHTING TRIGGERING IT)
        }
        if (mTrackableBehaviour.TrackableName == "card06" && vb.name == "vb1" && WasPressed == false)
        {
            Debug.Log("I Found your card06!");
            Numberaudio.Play();
            WasPressed = true; //Triggering the button pressed
            TallyAnim.Play("6tallyanim");
            StartCoroutine(DelayedMethod()); // DISABLING MULTIPLE PRESSES AT ONE GO (A MUST WITH VUFORIA VIRTUAL BUTTON DUE TO LIGHTING TRIGGERING IT)
        }
        if (mTrackableBehaviour.TrackableName == "card07" && vb.name == "vb1" && WasPressed == false)
        {
            Debug.Log("I Found your card07!");
            Numberaudio.Play();
            WasPressed = true; //Triggering the button pressed
            TallyAnim.Play("7Tally");
            StartCoroutine(DelayedMethod()); // DISABLING MULTIPLE PRESSES AT ONE GO (A MUST WITH VUFORIA VIRTUAL BUTTON DUE TO LIGHTING TRIGGERING IT)
        }
        if (mTrackableBehaviour.TrackableName == "card08" && vb.name == "vb1" && WasPressed == false)
        {
            Debug.Log("I Found your card08!");
            Numberaudio.Play();
            WasPressed = true; //Triggering the button pressed
            TallyAnim.Play("8Tallyanim");
            StartCoroutine(DelayedMethod()); // DISABLING MULTIPLE PRESSES AT ONE GO (A MUST WITH VUFORIA VIRTUAL BUTTON DUE TO LIGHTING TRIGGERING IT)
        }
        if (mTrackableBehaviour.TrackableName == "card09" && vb.name == "vb1" && WasPressed == false)
        {
            Debug.Log("I Found your card09!");
            Numberaudio.Play();
            WasPressed = true; //Triggering the button pressed
            TallyAnim.Play("9Tallyanim");
            StartCoroutine(DelayedMethod()); // DISABLING MULTIPLE PRESSES AT ONE GO (A MUST WITH VUFORIA VIRTUAL BUTTON DUE TO LIGHTING TRIGGERING IT)
        }
        if (mTrackableBehaviour.TrackableName == "card10" && vb.name == "vb1" && WasPressed == false)
        {
            Debug.Log("I Found your card10!");
            Numberaudio.Play();
            WasPressed = true;
            TallyAnim.Play("10Tallyanim");
            StartCoroutine(DelayedMethod()); 
        }
    } //When virtual button is pressed


    public void OnButtonReleased(VirtualButtonBehaviour vb) //When virtual button is released
    {
              
       //PUT ANYTHING RELATED TO BUTTON RELEASE
    }
    
    IEnumerator DelayedMethod() //Delaying the button presses
    {
        yield return new WaitForSeconds(5); //set to 5 seconds delay until the play button is set to recieve commands
        WasPressed = false; //Reset presses
    }
}