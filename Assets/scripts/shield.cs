using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    public BoxCollider2D BC;

    public float timer;
  

    void OnEnable()
    {
        timer = 3;
        BC.enabled = false;
    }

    
    void Update()
    {
        timer -= Time.deltaTime;
        
        if (timer<0)
        {
            BC.enabled = true;
            gameObject.SetActive(false);
        }
    }

    

}
