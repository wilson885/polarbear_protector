using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startmenu : MonoBehaviour {

	public void Start () {
		StartCoroutine (stop());
	}


	private IEnumerator stop () {
		yield return new WaitForSeconds (3);
		transform.position = new Vector3 (-484.5f, -103.5f, -78);
	}
}
