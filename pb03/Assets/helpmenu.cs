using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpmenu : MonoBehaviour {
	[SerializeField] private AudioSource soundsource;
	[SerializeField] private AudioClip button;
	// Use this for initialization
	void Start () {
		StartCoroutine (stop2 ());
	}
	
	// Update is called once per frame
	void OnMouseDown () {
		soundsource.PlayOneShot (button);
			Time.timeScale = 1; 
			Destroy (this.gameObject);
	}
	private IEnumerator stop2(){
		yield return new WaitForSeconds (1);
		Time.timeScale = 0;
	}
}
