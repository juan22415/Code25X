using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour {



    public GameObject[] spawners;
    private float timer;
    private int current;
    [SerializeField]
    private float maxtime;
    private float currentscore;



    private void Start()
    {

        maxtime = 5;
        currentscore = scoring.score;
    }


    // Update is called once per frame
    void Update () {


        if (currentscore!=scoring.score)
        {
            maxtime -= 0.1f;
            //maxtime = maxtime - scoring.score / 1000;
            currentscore = scoring.score;

        }
        timer += Time.deltaTime;
        
        



        if (timer > maxtime)

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
