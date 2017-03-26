using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Display.displays[0].Activate();
	}

	// Update is called once per frame
	void Update () {

    }
}
