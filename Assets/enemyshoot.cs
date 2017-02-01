using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyshoot : MonoBehaviour {


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
            shooting(1);
            shooting(-1);
        }


    }

    void shooting(int direction)
    {
        GameObject bullet = Instantiate(enemybullet);
        bullet.transform.position = GetComponent<Transform>().position + new Vector3(0, -0.3f, 0);
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0.5f * direction, -2f);
        timer = 0.5f;
    }
}
