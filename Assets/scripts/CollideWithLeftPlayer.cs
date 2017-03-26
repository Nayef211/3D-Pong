using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideWithLeftPlayer : MonoBehaviour {
	float score;
	void Start(){
		score = 0;
	}


	void Update(){
		
		OnGUI ();
	}


	void OnGUI () {
		GUI.Label (new Rect (0,0,100,50), score.ToString());
	}

	void onCollisionEnter(Collision col){
		if (col.gameObject.name == "RightPlayer") {
			score++;
       

		}
	}

}