using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMove : MonoBehaviour {

	public float movespeedR;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

        Vector3 pos = GameObject.Find("palmFollow").transform.position;
  
        pos.z = 24;
        transform.position = pos;

        //transform.Translate (Input.GetAxis ("Horizontal2")*movespeedR, Input.GetAxis ("Vertical2")*movespeedR, 0);
	}
}


