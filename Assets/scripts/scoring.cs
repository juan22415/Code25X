using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoring : MonoBehaviour
{ 

    public Text scoreui;
    public static float score;


    public void nextscene()
    {
        SceneManager.LoadScene(0);
        score = 0;
        Time.timeScale = 1;
    }

    public void restart()
    {
        SceneManager.LoadScene(2);
        score = 0;
        
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        scoreui.text = "Score: " + score; 
	}

    public void morescore()
    {
        score += 1;
    }

    
}
