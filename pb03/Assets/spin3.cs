using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin3 : MonoBehaviour {


	[SerializeField] private AudioSource soundsource;
	[SerializeField] private AudioClip buttonsound;

	// Use this for initialization
	void Start () {
		
	}
	void OnMouseDown()
	{
		soundsource.PlayOneShot (buttonsound);
		Application.Quit();
	}
	void OnMouseOver()
	{
		transform.Rotate (0, 1, 0);
	}
}
