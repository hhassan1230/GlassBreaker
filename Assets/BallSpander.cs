using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpander : MonoBehaviour {
	public GameObject ball;
	public float speed;
	private GameObject spawnPoint;

	// Use this for initialization
	void Start () {
		spawnPoint = GameObject.FindGameObjectWithTag ("SpawnPoint");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Rigidbody ballInstance;
			GameObject spawnedBall = Instantiate (ball, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
			ballInstance = spawnedBall.GetComponent<Rigidbody> ();
			ballInstance.AddForce (spawnPoint.transform.forward * speed);
		}
	}
}
