using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMoveKeyboard : MonoBehaviour {
	public float movespeedR;
	void Start(){
	}

	void Update(){
	transform.Translate (Input.GetAxis ("Horizontal2")*movespeedR, Input.GetAxis ("Vertical2")*movespeedR, 0);
	
	}
	}