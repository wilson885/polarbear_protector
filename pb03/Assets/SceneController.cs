using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {
	[SerializeField] private GameObject enemyPrefab;
	[SerializeField] private GameObject bearPrefab;

	private GameObject _enemy;
	private GameObject _bear;

	void Start () {
		StartCoroutine (create());
		
	}
	private IEnumerator create () {
		int angle = Random.Range (150, 300);
		int angle2 = Random.Range (-500, -700);
		float time_random = Random.Range (2, 10);
		yield return new WaitForSeconds (time_random);
		if (_enemy ==null) {
			_enemy = Instantiate (enemyPrefab)as GameObject;
			_enemy.transform.position = new Vector3 (0, 1, 0);
			_enemy.transform.localScale = new Vector3 (70.0f, 45.0f, 70.0f);
			_enemy.transform.Translate (angle,0 ,angle2);
		}
		if (_bear == null) 
		{
			_bear = Instantiate (bearPrefab)as GameObject;
			_bear.transform.position = new Vector3 (0, 1, 0);
			_bear.transform.localScale = new Vector3 (45.0f, 45.0f, 45.0f);
			_bear.transform.Translate (angle-250,28 ,angle2+500);
		}
		Destroy (this.gameObject);
	}


}
