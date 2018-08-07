using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class NoARPlease : MonoBehaviour {


    // Use this for initialization
    void Start ()
    {
        Debug.Log("hallo");
        TrackerManager.Instance.GetTracker<ObjectTracker>().Stop();
    }

    // Update is called once per frame
    void Update () {
	}
}
