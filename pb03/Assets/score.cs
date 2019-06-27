using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
	TextMesh text01;
	int h=0;
	// Use this for initialization
	void Start () {
		text01=GetComponent<TextMesh>();
	}

	public void Update2 () {
		h++;
		text01.text = h.ToString();
	}
}
