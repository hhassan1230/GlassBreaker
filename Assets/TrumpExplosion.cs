using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Exploder.Utils;

public class TrumpExplosion : MonoBehaviour {

	void Awake()
	{
		//		exploder.CrackObject(obj1); // exploder is not defined
//		Exploder.CrackedObject(this.gameObject); // Does not do anything
		ExploderSingleton.ExploderInstance.CrackObject(this.gameObject);


	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "bullet") {
			print ("I should explode!!!");
			ExploderSingleton.ExploderInstance.ExplodeCracked(this.gameObject);

			//			Exploder.ExplodeCracked(this.gameObject); // Errors
//			ExploderSingleton.ExploderInstance.ExplodeObject (this.gameObject); // This works but takes too long
		}
	}
}
