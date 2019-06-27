using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
	[SerializeField] private AudioSource soundsource;
	[SerializeField] private AudioClip button;
	public int _health=0;

	int damage = 1;
	public Camera _camera;
	// Use this for initialization
	void Start ()
	{
		_health = 0;
		_camera.GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public int Hurt ()
	{
		float posx = _camera.pixelWidth / 2;
		float posy = _camera.pixelHeight / 2;
		_health += damage;
		Debug.Log ("Health: " + _health);
		if (_health == 10) {

			Time.timeScale = 0;
		}
		return _health;

	}
	public int re ()
	{
		_health = _health + 1;
		return _health;
	}

	void OnGUI ()
	{
		float posx = _camera.pixelWidth / 2;
		float posy = _camera.pixelHeight / 2;
		GUIStyle ml = new GUIStyle (GUI.skin.label);
		ml.fontSize = 30;
		Font myf = (Font)Resources.Load ("Noteworthy", typeof(Font));
		ml.font = myf;
		/*GUI.Label (new Rect (10, 10, 1000, 200), "the  life  you  save  "+_health.ToString(),ml);*/
		if (GUI.Button (new Rect (posx - 100, posy + 120, 200, 30), "START")) {
			Time.timeScale = 1; 
			soundsource.PlayOneShot (button);
			Destroy (this.gameObject);
		}
		if (GUI.Button (new Rect (posx - 100, posy + 200, 200, 30), "QUIT")) { 
			soundsource.PlayOneShot (button);
			Application.Quit ();
		}

	}
}
