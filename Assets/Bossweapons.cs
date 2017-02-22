using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossweapons : MonoBehaviour {


    public int lifepoints = 30;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (lifepoints<1)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.tag == "bulletR" && Bosscolor.isred==true)
        {
            lifepoints--;
        }

        if (other.gameObject.tag == "bulletB" && Bosscolor.isred == false)
        {
            lifepoints--;
        }
    }
}
