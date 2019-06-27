using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hscreate : MonoBehaviour {
	[SerializeField] private GameObject enemyPrefab;
	private GameObject _enemy;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (_enemy == null) {
			_enemy = Instantiate (enemyPrefab)as GameObject;
		}
	}
}
