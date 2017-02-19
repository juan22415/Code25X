using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Boundary
{
    public float xMin, xMax, yMin, yMax;
}

public class acelemove : MonoBehaviour {
    public Boundary boundary;
    [SerializeField]
    private float speed=0.2f;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Input.acceleration.x*speed, 0 , 0);


        GetComponent<Rigidbody2D>().position = new Vector3
      (
          Mathf.Clamp(GetComponent<Rigidbody2D>().position.x, boundary.xMin, boundary.xMax),
          Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, boundary.yMin, boundary.yMax),
          0.0f
          
      );
        //rb.AddForce(new Vector2 (Input.acceleration.x * speed, 0));
    }
}
