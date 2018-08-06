using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Howtoplay2 : MonoBehaviour {


    public GameObject howtoplaypanel;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}


    private void OnTriggerEnter(Collider other)
    {
        howtoplaypanel.SetActive(true);
    }
}
