using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR;
using Vuforia;

public class CardsController : MonoBehaviour
{

    //Enable tally gameobject
    public GameObject EnableTallyOne;
    public GameObject EnableTallyTwo;
    public GameObject EnableTallyThree;
    public GameObject EnableTallyFour;
    public GameObject EnableTallyFive;
    public GameObject EnableTallySix;
    public GameObject EnableTallySeven;
    public GameObject EnableTallyEight;
    public GameObject EnableTallyNine;
    public GameObject EnableTallyTen;

    //Tally virtual button
    public GameObject VirtualButtonTallyOne;
    public GameObject VirtualButtonTallyTwo;
    public GameObject VirtualButtonTallyThree;
    public GameObject VirtualButtonTallyFour;
    public GameObject VirtualButtonTallyFive;
    public GameObject VirtualButtonTallySix;
    public GameObject VirtualButtonTallySeven;
    public GameObject VirtualButtonTallyEight;
    public GameObject VirtualButtonTallyNine;
    public GameObject VirtualButtonTallyTen;

    //Audio virtual button should later be added here


    //Tally animation controller
    public Animator TallyAnimationOne;
    public Animator TallyAnimationTwo;
    public Animator TallyAnimationThree;
    public Animator TallyAnimationFour;
    public Animator TallyAnimationFive;
    public Animator TallyAnimationSix;
    public Animator TallyAnimationSeven;
    public Animator TallyAnimationEight;
    public Animator TallyAnimationNine;
    public Animator TallyAnimationTen;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StateManager sm = TrackerManager.Instance.GetStateManager();
        IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

        foreach (TrackableBehaviour tb in tbs)
        {
            string name = tb.TrackableName;
            if (tb.GetType().Equals(TrackableType.All))
            {
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);
            }
        }
    }
}

    
