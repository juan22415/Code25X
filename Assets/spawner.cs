using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject enemy;
    public Transform thistransform;
    public float timer;

    // Use this for initialization
    void Start () {

        thistransform = GetComponent<Transform>();


       
    }
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if (timer>3)

        {
            spawn();
        }
    }

    void spawn ()
    {
        GameObject enemyprefab = Instantiate(enemy);
        enemyprefab.transform.position = thistransform.position;
       

        timer = 0;
    }
}
