using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_3 : MonoBehaviour {

    private int liefepoints = 2;
    public GameObject particle;
    public bool isred;


    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0.7f, -0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        if (liefepoints == 0)
        {
            GameObject particles = Instantiate(particle);
            particles.transform.position = GetComponent<Transform>().position;
            scoring.score += 100;
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "bulletR" || coll.gameObject.tag == "bulletB")
        {
            if (coll.gameObject.tag == "bulletR" && isred == true)
            {
                liefepoints -= 1;
            }
            if (coll.gameObject.tag == "bulletB" && isred == false)
            {
                liefepoints -= 1;
            }
            Destroy(coll.gameObject);

        }
        else if (coll.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }
    }


}
