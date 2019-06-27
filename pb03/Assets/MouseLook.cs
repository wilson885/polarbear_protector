using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {
	public enum RotationAxes{
		MouseXAndY = 0,
		MouseX = 1,
		MouseY = 2
	}
	public RotationAxes axes = RotationAxes.MouseXAndY;

	public float sensitivityHor = 1;
	public float sensitivityVert =1;

	public float minimumVert = -45.0f;
	public float maximumVert = 45.0f;

	private float _rotationX = 0;
	// Update is called once per frame
	void Start () {
		Rigidbody body = GetComponent<Rigidbody> ();
		if (body != null)
			body.freezeRotation = true;
	}
	void Update () {
		Vector3 targetpos = Camera.main.WorldToScreenPoint (this.transform.position);
		this.transform.position =new Vector3(0.1f*Input.GetAxis ("Mouse X"),0.1f*Input.GetAxis ("Mouse Y"));

	}
}
