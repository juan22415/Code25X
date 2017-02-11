using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour {



    public GameObject[] spawners;
    private float timer;
    private int current;

	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;

        if (timer > 3)

        {
            current = Random.Range(0, spawners.Length);
            
            Enabler(current);

        }



        }

        void Enabler (int pos)
    {
        spawners[pos].SetActive(true);
        timer = 0;
        spawners[pos].SetActive(false);

    }

}
