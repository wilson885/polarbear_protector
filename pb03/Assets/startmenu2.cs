using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startmenu2 : MonoBehaviour {

	public void Start () {
		StartCoroutine (stop());
	}


	private IEnumerator stop () {
		yield return new WaitForSeconds (3);
		transform.position = new Vector3 (26, 109, -101);
	}
}
