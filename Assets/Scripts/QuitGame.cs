﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour {

    public void OnClick()
    {
        Debug.Log("test");
        Application.Quit();
    }
}
