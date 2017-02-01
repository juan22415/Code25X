using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_1 : MonoBehaviour {

    private int liefepoints=3;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1);
	}
	
	// Update is called once per frame
	void Update () {
		if (liefepoints==0)
        {
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(coll.gameObject);
        liefepoints -= 1;
    }
}
