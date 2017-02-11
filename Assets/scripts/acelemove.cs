using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acelemove : MonoBehaviour {

    [SerializeField]
    private float speed=0.2f;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Input.acceleration.x*speed, 0, 0);

        //rb.AddForce(new Vector2 (Input.acceleration.x * speed, 0));
    }
}
