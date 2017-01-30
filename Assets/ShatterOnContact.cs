using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Exploder.Utils;

public class ShatterOnContact : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "bullet") {
			print ("I should explode!!!");
			ExploderSingleton.ExploderInstance.ExplodeObject (this.gameObject);
		}
	}
}
