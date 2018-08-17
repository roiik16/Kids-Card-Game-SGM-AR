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

    bool Drone;
    bool Card2;
    bool Card3;
    bool Card4;
    bool Card5;
    bool Card6;
    bool Card7;
    bool Card8;
    bool Card9;
    bool Card10;

    private void OnTrackingFound()
    {
        if (mTrackableBehaviour.TrackableName == "Drone") //Card1
        {
            Drone = true;
            Debug.Log("Drone found" + Drone);
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2)); //Play Clip
        }

        if (mTrackableBehaviour.TrackableName == "2FINAL") //Cards2
        {
            Card2 = true;

            Debug.Log("Card2 found" + Card2);
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2)); //Play Clip
           
        }


        if (mTrackableBehaviour.TrackableName == "3FINAL") //Cards2
        {
            Card3 = true;

            Debug.Log("3FINAL found" + Card3);
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2)); //Play Clip
            
        }

        if (mTrackableBehaviour.TrackableName == "4FINAL") //Cards2
        {
            Card4 = true;

            Debug.Log("4FINAL found" + Card3);
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2)); //Play Clip
           
        }

        if (mTrackableBehaviour.TrackableName == "5FINAL") //Cards2
        {
            Card5 = true;

            Debug.Log("5FINAL found" + Card5);
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2)); //Play Clip
          
        }

        if (mTrackableBehaviour.TrackableName == "6FINAL") //Cards2
        {
            Card6 = true;

            Debug.Log("6FINAL found" + Card6);
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2)); //Play Clip
            
        }

        if (mTrackableBehaviour.TrackableName == "7FINAL") //Cards2
        {
            Card7 = true;

            Debug.Log("7FINAL found" + Card7);
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2)); //Play Clip
           
        }

        if (mTrackableBehaviour.TrackableName == "8FINAL") //Cards2
        {
            Card8 = true;

            Debug.Log("8FINAL found" + Card8);
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2)); //Play Clip
            
        }

        if (mTrackableBehaviour.TrackableName == "9FINAL") //Cards2
        {
            Card9 = true;

            Debug.Log("9FINAL found" + Card9);
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2)); //Play Clip
            
        }

        if (mTrackableBehaviour.TrackableName == "10FINAL") //Cards2
        {
            Card10 = true;

            Debug.Log("10FINAL found" + Card10);
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2)); //Play Clip
            
        }

        
        Debug.Log("Checking for matches" + Drone + Card2);
        CardMatch();
    }

    //CardMatch - To detect if two cards have been found and play matched audio clip
    public void CardMatch()
    {
        // Debug.Log("Checking for matches" + Drone + Fissure);

        if (Drone == true && Card2 == true)
        {
            Debug.Log("Both True");
        }
    }


    public void OnTrackingLost()
    {
        Drone = false; Card2 = false; Card3 = false; Card4 = false; Card5 = false; Card6 = false; Card7 = false; Card8 = false; Card9 = false; Card10 = false;
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        if (mTrackableBehaviour.TrackableName == "Drone" && vb.name == "vb1") //Check what is the tracked name
        {
            Debug.Log("I Found your drone!"); //Print info
            TallyAnim.Play("OneTally"); //Play anim
        }

        if (mTrackableBehaviour.TrackableName == "2FINAL" && vb.name == "vb1")
        {
            Debug.Log("I Found your 2FINAL!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            TallyAnim.Play("TwoTally");
        }

        if (mTrackableBehaviour.TrackableName == "3FINAL" && vb.name == "vb1")
        {
            Debug.Log("I Found your 2FINAL!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
        if (mTrackableBehaviour.TrackableName == "4FINAL" && vb.name == "vb1")
        {
            Debug.Log("I Found your 2FINAL!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
        if (mTrackableBehaviour.TrackableName == "5FINAL" && vb.name == "vb1")
        {
            Debug.Log("I Found your 2FINAL!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
        if (mTrackableBehaviour.TrackableName == "6FINAL" && vb.name == "vb1")
        {
            Debug.Log("I Found your 2FINAL!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
        if (mTrackableBehaviour.TrackableName == "7FINAL" && vb.name == "vb1")
        {
            Debug.Log("I Found your 2FINAL!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
        if (mTrackableBehaviour.TrackableName == "8FINAL" && vb.name == "vb1")
        {
            Debug.Log("I Found your 2FINAL!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
        if (mTrackableBehaviour.TrackableName == "9FINAL" && vb.name == "vb1")
        {
            Debug.Log("I Found your 2FINAL!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
        if (mTrackableBehaviour.TrackableName == "10FINAL" && vb.name == "vb1")
        {
            Debug.Log("I Found your 2FINAL!");
            AudioSource.PlayClipAtPoint(clip, new Vector3(5, 1, 2));

            //TallyAnim.Play("Testanim2");
        }
    }

    //ON VIRTUAL BUTTON RELEASE
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        TallyAnim.Play("None");
    }
}