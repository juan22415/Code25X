using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosslife : MonoBehaviour {
    [SerializeField]
    private int lifepoints=50;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(lifepoints<1)
        {
            Destroy(gameObject);
        }
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(coll.gameObject);

        if(coll.gameObject.tag == "bulletR" && Bosscolor.isred == true)
            {
                lifepoints--;
            }

        if (coll.gameObject.tag == "bulletB" && Bosscolor.isred == false)
        {
            lifepoints--;
        }
    }
}
