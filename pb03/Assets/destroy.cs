using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour {

	// Use this for initialization
	public void Start () {
		StartCoroutine (stop());
	}
	private IEnumerator stop () {
		yield return new WaitForSeconds (1);
		Destroy (this.gameObject);
	}
}
