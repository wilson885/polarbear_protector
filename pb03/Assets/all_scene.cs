using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class all_scene : MonoBehaviour {
	[SerializeField] private GameObject enemyPrefab;
	private GameObject _enemy;
	[SerializeField] private GameObject handPrefab;
	private GameObject _hand;
	/*[SerializeField] private GameObject enemyPrefab2;
	private GameObject _enemy2;*/
	// Use this for initialization
	void Start () {
		StartCoroutine (create2());
	}
	
	// Update is called once per frame
	void Update () {
		int angle = Random.Range (26, 342);
		int angle2 = Random.Range (-335, -723);
		if (_enemy ==null) {
			_enemy = Instantiate (enemyPrefab)as GameObject;
			_enemy.transform.position = new Vector3 (0, 1, 0);
			_enemy.transform.localScale = new Vector3 (45.0f, 45.0f, 45.0f);
			_enemy.transform.Translate (angle,0 ,angle2);
		}


		/*if (_enemy2 == null) {
				_enemy2 = Instantiate (enemyPrefab2)as GameObject;
				_enemy2.transform.position = new Vector3 (0, 1, 0);
		}*/
	}
	private IEnumerator create2 () {
		yield return new WaitForSeconds (0);
		if (_hand == null) 
		{
			_hand = Instantiate (handPrefab)as GameObject;
		}
	}
}
