using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour {
	[SerializeField] private AudioSource soundsource;
	[SerializeField] private AudioClip buttonsound;

	public Light dark;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown()
	{
		soundsource.PlayOneShot (buttonsound);
		dark.intensity = 0;
		Time.timeScale = 0; 
	}
	void OnMouseOver()
	{
		transform.Rotate (0, 1, 0);
	}
}
