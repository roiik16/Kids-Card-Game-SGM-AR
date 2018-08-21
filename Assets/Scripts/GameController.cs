using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

//CARD CONTROLLER SCRIPT
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

    public AudioClip clip; //Number Sound clip
    public GameObject vbBtnObj; //Virtual Button
    public Animator TallyAnim; //Tally animation
    
    //Booleans created to be able to detect multiple cards at once and play the corresponding audio.
    bool Card01;
    bool Card02;
    bool Card03;
    bool Card04;
    bool Card05;
    bool Card06;
    bool Card07;
    bool Card08;
    bool Card09;
    bool Card10;

    private void OnTrackingFound()
    {
        if (mTrackableBehaviour.TrackableName == "Card01") //Card1
        {
            Card01 = true;
        }

        if (mTrackableBehaviour.TrackableName == "Card02")
        {
            Card02 = true;
          
        }
        
        if (mTrackableBehaviour.TrackableName == "Card03") //Cards2
        {
            Card03 = true;
            
        }

        if (mTrackableBehaviour.TrackableName == "Card04") //Cards2
        {
            Card04 = true;           
        }

        if (mTrackableBehaviour.TrackableName == "Card05") //Cards2
        {
            Card05 = true;          
        }

        if (mTrackableBehaviour.TrackableName == "Card06") //Cards2
        {
            Card06 = true;            
        }

        if (mTrackableBehaviour.TrackableName == "Card07") //Cards2
        {
            Card07 = true;         
        }

        if (mTrackableBehaviour.TrackableName == "Card08") //Cards2
        {
            Card08 = true;            
        }

        if (mTrackableBehaviour.TrackableName == "Card09") //Cards2
        {
            Card09 = true;          
        }

        if (mTrackableBehaviour.TrackableName == "Card10") //Cards2
        {
            Card10 = true;            
        }

        CardMatch();
    }

    //CardMatch - To detect if two cards have been found and play matched audio clip
    public void CardMatch()
    {
        // Debug.Log("Checking for matches" + Drone + Fissure);

        if (Card01 == true && Card02 == true)
        {
            Debug.Log("Both True");
        }
    }

    public void OnTrackingLost()
    {
        Card01 = false; Card02 = false; Card03 = false; Card04 = false; Card05 = false; Card06 = false; Card07 = false; Card08 = false; Card09 = false; Card10 = false; //Releasing boolean
    }

    bool WasPressed; //Bool virtual button detector

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (mTrackableBehaviour.TrackableName == "CardsAttempt2" && vb.name == "vb1" && WasPressed == false) //Check what is the tracked name
        {
            Debug.Log("I Found your Attempt2 and button clicked!"); //Print info
            TallyAnim.Play("OneTallyAnim"); //Play tally anim
            AudioSource.PlayClipAtPoint(clip, new Vector3(171, 200, -3000), 20); //Play Clip
            WasPressed = true; //Triggering the button pressed
            StartCoroutine(DelayedMethod()); // DISABLING MULTIPLE PRESSES AT ONE GO (A MUST WITH VUFORIA VIRTUAL BUTTON DUE TO LIGHTING TRIGGERING IT)
        }

        if (mTrackableBehaviour.TrackableName == "Card02" && vb.name == "vb1")
        {
            Debug.Log("I Found your Card02!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));
            TallyAnim.Play("TwoTallyAnim");
        }

        if (mTrackableBehaviour.TrackableName == "Card03" && vb.name == "vb1")
        {
            Debug.Log("I Found your Card03!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));
            TallyAnim.Play("Threetallyanim");
        }
        if (mTrackableBehaviour.TrackableName == "Card04" && vb.name == "vb1")
        {
            Debug.Log("I Found your Card04!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
        if (mTrackableBehaviour.TrackableName == "Card05" && vb.name == "vb1")
        {
            Debug.Log("I Found your Card05!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
        if (mTrackableBehaviour.TrackableName == "Card06" && vb.name == "vb1")
        {
            Debug.Log("I Found your Card06!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
        if (mTrackableBehaviour.TrackableName == "Card07" && vb.name == "vb1")
        {
            Debug.Log("I Found your Card07!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
        if (mTrackableBehaviour.TrackableName == "Card08" && vb.name == "vb1")
        {
            Debug.Log("I Found your Card08!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
        if (mTrackableBehaviour.TrackableName == "Card09" && vb.name == "vb1")
        {
            Debug.Log("I Found your Card09!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
        if (mTrackableBehaviour.TrackableName == "Card10" && vb.name == "vb1")
        {
            Debug.Log("I Found your Card10!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
    }

    //ON VIRTUAL BUTTON RELEASE
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
       //PUT ANYTHING RELATED TO BUTTON RELEASE
    }



    IEnumerator DelayedMethod() //Delaying the button presses
    {
        yield return new WaitForSeconds(5); //set to 5 seconds
        WasPressed = false; //Reset presses
    }
}