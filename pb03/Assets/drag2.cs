using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag2 : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void OnMouseOver () {
		Vector3 targetpos = Camera.main.WorldToScreenPoint (this.transform.position);
		Vector3 mousepos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, targetpos.z);
		Vector3 newpos = Camera.main.ScreenToWorldPoint (mousepos);
		this.gameObject.transform.position = newpos;

	}
	//void OnMouseExit(){
			//this.transform.position -= new Vector3 (0, 0, 0);
	//}
}
