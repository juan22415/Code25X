using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bossshoot : MonoBehaviour {


    public Transform[] weapons;
    public Transform Playertransform;

    public GameObject enemybullet;
    private float timer;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;
        if (timer < 0)
        {
            int i = Random.Range(0, 3);
            Debug.Log(i);
            shooting(i);

        }
    }


    void shooting(int weapon)
    {
        GameObject bullet = Instantiate(enemybullet);
        bullet.transform.position = weapons[weapon].position + new Vector3(0, -0.3f, 0);
        bullet.GetComponent<Rigidbody2D>().velocity = Playertransform.position - weapons[weapon].position;
        timer =1;
    }
}
