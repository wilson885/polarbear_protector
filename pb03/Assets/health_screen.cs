using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_screen : MonoBehaviour {

	TextMesh _tt;
	public cubedelete _cb;
	private int a; 
	void Start () {
		_tt = GetComponent<TextMesh> ();
	}
	void Update () {
		_tt.text = a.ToString();
	}
}
