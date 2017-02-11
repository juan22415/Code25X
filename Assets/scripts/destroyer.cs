using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(coll.gameObject);
    }
    void OnTriggerEnter2D (Collider2D coll)
    {
        Destroy(coll.gameObject);
    }
}
