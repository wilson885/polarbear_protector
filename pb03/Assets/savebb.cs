using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class savebb : MonoBehaviour {

	[SerializeField] private GameObject savePrefab;
	private GameObject _save;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	public void create2() {
			float angle = Random.Range (-30,150);
			_save = Instantiate (savePrefab)as GameObject;
			_save.transform.position = new Vector3 (0, 14, -696);
			_save.transform.localScale = new Vector3 (55.0f, 55.0f, 55.0f);
			_save.transform.Translate (angle,0,0);
			//b++;
			Debug.Log("fuck yeah");
	}
}
