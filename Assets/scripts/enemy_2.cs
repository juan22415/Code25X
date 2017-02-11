using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_2 : MonoBehaviour
{

    private int liefepoints = 2;
    public GameObject particle;


    // Use this for initialization
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-1, -1);
    }

    // Update is called once per frame
    void Update()
    {
        if (liefepoints == 0)
        {
            Destroy(gameObject);
            GameObject particles = Instantiate(particle);
            particles.transform.position = GetComponent<Transform>().position;
            scoring.score += 100;
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.gameObject.tag == "bullet")
        {
            Destroy(coll.gameObject);
            liefepoints -= 1;

        }
        else if (coll.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }
    }


}
