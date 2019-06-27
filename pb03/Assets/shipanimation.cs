using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipanimation : MonoBehaviour {
	/*[SerializeField] private AudioSource soundsource;
	[SerializeField] private AudioClip ship;
	public shipsound _shs;*/
	void Start () {
	}
	int a=0;
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			a = a + 1;
		}
		if (a>=2) {
			this.transform.position += new Vector3 (-1, 0, -1);
			Time.timeScale = 0;
			if (this.transform.position.x < -500) {
				Destroy (this.gameObject);
				Time.timeScale = 1;
			}
		}
	}
	void OnMouseDown () {
		Destroy (this.gameObject);

	}
}
