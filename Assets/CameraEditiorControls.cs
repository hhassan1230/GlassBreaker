using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEditiorControls : MonoBehaviour {
	public float speed = 5f;

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
			
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis("Mouse X") * speed;
		float vertical = Input.GetAxis("Mouse Y") * speed;

		transform.Rotate(0f, horizontal, 0f, Space.World);
		transform.Rotate(-vertical, 0f, 0f, Space.Self);

		// andThenShakeItLikeAPolaroiddPicture
	}
}
