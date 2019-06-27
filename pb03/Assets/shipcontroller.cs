using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipcontroller : MonoBehaviour {

	[SerializeField] private GameObject shipPrefab;
	private GameObject _ship;

	void Start () {
		StartCoroutine (create());

	}
	private IEnumerator create () {
		StartCoroutine (create());
		yield return new WaitForSeconds (20);
		if (_ship == null) 
		{
			_ship = Instantiate (shipPrefab)as GameObject;
			_ship.transform.position = new Vector3 (200, 220, 500);
			_ship.transform.rotation = Quaternion.Euler(0, 30, 0);
			_ship.transform.localScale=new Vector3(200,200,200);
		}
	}
}
