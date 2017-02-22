using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosscolor : MonoBehaviour {

    public static bool isred = true;
    [SerializeField]
    private SpriteRenderer srenderer;
    private float timer;

	// Use this for initialization
	void Start () {
        srenderer = GetComponent<SpriteRenderer>();

        
    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer>5)
        {
            colorswap();
            timer = 0;
        }

	}


    public void colorswap ()

    {
        if(isred==false)
        {
            srenderer.color = Color.red;
            isred = true;
        }

        else if (isred == true)
        {
            srenderer.color = Color.blue;
            isred = false;
        }
    }


   
}
