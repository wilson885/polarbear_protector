using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousehover : MonoBehaviour {
	public void Start () {
		StartCoroutine (stop());
	}


	private IEnumerator stop () {
		yield return new WaitForSeconds (0);
		Time.timeScale = 0; 
	}
}
