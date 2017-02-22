using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour {



    public GameObject[] spawners;
    private float timer;
    private int current;
    [SerializeField]
    private float maxtime;
    private float scorecheck;



    private void Start()
    {

        maxtime = 5;
        scorecheck = scoring.score;
    }


    // Update is called once per frame
    void Update () {

         if (scoring.score- scorecheck >=500)
        {
            maxtime -= 0.2f;
            //maxtime = maxtime - scoring.score / 1000;
            scorecheck = scoring.score;

        }
        timer += Time.deltaTime;
        
        if (timer > maxtime)

        {
            current = Random.Range(0, spawners.Length);
            
            Enabler(current);
          }

        if (scoring.score>4500)
        {

            gameObject.SetActive(false);
        }


}

        void Enabler (int pos)
    {
        spawners[pos].SetActive(true);
        timer = 0;
        spawners[pos].SetActive(false);

    }

}
