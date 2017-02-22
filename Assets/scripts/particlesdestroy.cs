using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particlesdestroy : MonoBehaviour
{

    public ParticleSystem pa;
    // Use this for initialization
    void Start()
    {
        pa = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {

        if (pa.isPlaying == false)
        {
            Destroy(gameObject);
        }
    }

}
