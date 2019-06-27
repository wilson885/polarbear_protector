using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beardelete : MonoBehaviour {
	
	public void Start () {
		StartCoroutine (delete());

	}

	// Update is called once per frame
	private IEnumerator delete () {
		this.transform.Translate (0, 0, 0);
		yield return new WaitForSeconds (10);
		Destroy (this.gameObject);
	}

}
