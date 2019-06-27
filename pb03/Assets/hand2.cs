using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetpos = Camera.main.WorldToScreenPoint (this.transform.position);
		Vector3 mousepos = new Vector3 (Input.mousePosition.x-10, Input.mousePosition.y-12, targetpos.z);
		Vector3 newpos = Camera.main.ScreenToWorldPoint (mousepos);
		this.gameObject.transform.position = newpos;
	}
}
