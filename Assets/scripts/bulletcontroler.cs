    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletcontroler : MonoBehaviour {

    public GameObject bulletprefab;
    public Transform thistransform;
    private float timer=0.5f;

    // Use this for initialization
    void Start () {
        thistransform = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {

        timer -= Time.deltaTime;
        if (timer<0)
        {
            shooting();
        }
        
    }


    void shooting()
    {
        GameObject bullet = Instantiate(bulletprefab);
        bullet.transform.position = thistransform.position+new Vector3(0,0.3f,0);
        bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5f);
        timer = 0.5f;
    }
}
