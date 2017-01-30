using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBallTimer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("DestroyMe", 10);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DestroyMe() {
		this.gameObject.SetActive (false);
	}
}
