using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour {
	public Rigidbody rb;
	float Sy;
	float Sx;
	float Sz;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		Sx = Random.Range (0, 2) == 0 ? -1 : 1;
		Sy = Random.Range (0, 2) == 0 ? -1 : 1;
        Sz = 1;
        //Sz = Random.Range (0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector3 (Random.Range (3, 6) * Sx, Random.Range (3, 6) * Sy, Random.Range (5, 10) * Sz);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
