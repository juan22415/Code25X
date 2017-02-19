using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Characterlife : MonoBehaviour {

    [SerializeField]
    private int charlife=3,currentlife=0;
    [SerializeField]
    private GameObject shield;
    [SerializeField]
    private GameObject particle;
    [SerializeField]
    private GameObject panel;
    [SerializeField]
    private Scrollbar scrollbar;
    [SerializeField]
    private Text loserscore;

    public Image[] lifes;




    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (charlife<1)
        {
            
            GameObject particles = Instantiate(particle);
            particles.transform.position = GetComponent<Transform>().position;
            Destroy(gameObject);
            scrollbar.gameObject.SetActive(false);

            panel.SetActive(true);

            loserscore.text = "Score: " + scoring.score;

            Time.timeScale = 0;


            

        }

        

        
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag=="enemybullet")
        {
            lifes[currentlife].enabled = false;
            charlife -= 1;
            Respawn();
            currentlife++;

        }
    }


    void Respawn()
    {
        shield.SetActive(true);
        gameObject.transform.position = (new Vector3(0, -3.79f, 0));
    }

 
}
