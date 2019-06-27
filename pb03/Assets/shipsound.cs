using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipsound : MonoBehaviour {
	[SerializeField] private AudioSource soundsource;
	[SerializeField] private AudioClip ship;
	void Start () {
	}
	public void createsound () 
	{
		soundsource.PlayOneShot (ship);
	}

	void Update () {
		
	}
}
