using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMove : MonoBehaviour {
	public float movespeed;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		transform.Translate (Input.GetAxis ("Horizontal1")*movespeed, Input.GetAxis ("Vertical1")*movespeed, 0);
	}
}
