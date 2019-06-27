using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snow : MonoBehaviour {

	// Use this for initialization
	[SerializeField] private ParticleSystem _psprefab;
	private ParticleSystem _ps;

	void Start () {
		StartCoroutine (create());

	}
	private IEnumerator create () {
		yield return new WaitForSeconds (2);
		_ps = Instantiate (_psprefab)as ParticleSystem;
	}
}
