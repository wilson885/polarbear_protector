using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayshooter : MonoBehaviour {
	// Use this for initialization
	[SerializeField] private AudioSource soundsource;
	[SerializeField] private AudioClip catchbear;
	[SerializeField] private AudioClip hitground;

	public PlayerCharacter _hurt;
	public savebb _sb;
	public icedelete _id;
	public bearanimator _bd;
	public score _sc;
	public shipanimation _sa;


	void Start () {
	}
	// Update is called once per frame
	void  Update ()
	{
		this.transform.Translate (Input.GetAxis ("Mouse X")*0.15f,Input.GetAxis("Mouse Y")*0.1f,0);
		Vector3 targetpos = Camera.main.WorldToScreenPoint (this.transform.position);
		Vector3 mousepos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, targetpos.z);
		Ray ray = Camera.main.ScreenPointToRay (mousepos);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit)) {
			GameObject hitObject = hit.transform.gameObject;
			cubedelete target = hitObject.GetComponent<cubedelete> ();
			if (target != null) {
				if (Input.GetMouseButtonUp(0)) {
					target.notsve ();
				} else {
					if (Input.GetMouseButtonDown (0)) {
						soundsource.PlayOneShot (catchbear);
					}
					target.sve ();
				}
			}
			if (target != null && target.transform.position.x <= -150 && target.transform.position.y >= 20 && target.transform.position.y <= 120) {
				Debug.Log ("hit");
				soundsource.PlayOneShot (hitground);
				target.deleterightnow ();
				_id.deleterightnow2 ();
				_hurt.Hurt ();
				_sb.create2 ();
				_sc.Update2 ();
			} 
		}
	}
}

