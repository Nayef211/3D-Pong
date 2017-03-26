using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 pos = GameObject.Find("Sphere").transform.position;
        if (pos.z < 2) {
            pos.z = 0;
            transform.position = pos;
        }
        //transform.Translate(Input.GetAxis("Horizontal1"), Input.GetAxis("Vertical1"), 0);
    }
}
