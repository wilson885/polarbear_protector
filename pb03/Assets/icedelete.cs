using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class icedelete : MonoBehaviour {
	// Use this for initialization
	[SerializeField] private AudioSource soundsource;
	[SerializeField] private AudioClip melt;

	void Start () {
		StartCoroutine (delete());
	}
	
	// Update is called once per frame
	private IEnumerator delete () {
			this.transform.Translate(0, 0, 0);
			soundsource.PlayOneShot (melt);
			yield return new WaitForSeconds (6);
			Destroy (this.gameObject);
		    yield return new WaitForSeconds (4);
	}
	public void deleterightnow2()
	{
		this.gameObject.transform.Translate(0,-1000,0);
	}
}
