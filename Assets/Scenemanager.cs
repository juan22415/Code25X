﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenemanager : MonoBehaviour {

    public void nextscene()
    {
        SceneManager.LoadScene(1);
    }

    public void exitgame()
    {
        Application.Quit();
    }
    
}
