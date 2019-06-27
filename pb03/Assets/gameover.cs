using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {
	void Start()
	{
		Cursor.visible = true;
	}
		void Update ()
		{
		if( Input.GetMouseButtonDown(0) )
			{
				SceneManager.LoadScene( SceneManager.GetActiveScene().name );

			}
		}
}
