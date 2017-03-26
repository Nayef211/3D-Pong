using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTrasparent : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Color color = new Color(0.387f, 0.98f, 1.0f, 0.05f);
        gameObject.GetComponent<Renderer>().material.SetColor("_Color", color);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
