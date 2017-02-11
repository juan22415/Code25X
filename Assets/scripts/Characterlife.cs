using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Characterlife : MonoBehaviour {

    [SerializeField]
    private int charlife=3;
    [SerializeField]
    private GameObject shield;
    public GameObject particle;
    

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
            SceneManager.LoadScene(0);

        }

        

        
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag=="enemybullet")
        {
            charlife -= 1;
            Respawn();

        }
    }


    void Respawn()
    {
        shield.SetActive(true);
        gameObject.transform.position = (new Vector3(0, -3.79f, 0));
    }
}
