using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponslookat : MonoBehaviour {

    [SerializeField]
    private Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.up = transform.position - player.position;
    }
}
