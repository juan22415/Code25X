using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject enemy;
    public Transform thistransform;
    public float timer;



    void OnEnable()
    {
        thistransform = GetComponent<Transform>();
        spawn();

    }
    void spawn ()
    {
        GameObject enemyprefab = Instantiate(enemy);
        enemyprefab.transform.position = thistransform.position;
       

        timer = 0;
    }
}
