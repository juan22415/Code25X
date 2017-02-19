    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bulletcontroler : MonoBehaviour {

    public GameObject bulletprefabB,bulletprefabR;
    public Transform thistransform;
    public Scrollbar scrollbar;
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
        if (scrollbar.value >0.5f)
        {
            GameObject bullet = Instantiate(bulletprefabB);
            bullet.transform.position = thistransform.position+new Vector3(0,0.3f,0);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5f);
            timer = 0.5f;

        }

        else if (scrollbar.value <0.5f)
        {
            GameObject bullet = Instantiate(bulletprefabR);
            bullet.transform.position = thistransform.position + new Vector3(0, 0.3f, 0);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 5f);
            timer = 0.5f;

        }
    }
}
