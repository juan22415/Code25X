using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{ 

    public Text scoreui;
    public static int score;

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
