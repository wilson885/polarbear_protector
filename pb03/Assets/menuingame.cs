using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuingame : MonoBehaviour {

	public Camera _camera;
	// Use this for initialization
	void Start () {
		_camera.GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnGUI()
	{
		float posx = _camera.pixelWidth / 2;
		float posy = _camera.pixelHeight / 2;
		GUIStyle ml=new GUIStyle(GUI.skin.label);
		ml.fontSize = 30;
		Font myf = (Font)Resources.Load ("Noteworthy", typeof(Font));
		ml.font = myf;
		/*GUI.Label (new Rect (10, 10, 1000, 200), "the  life  you  save  "+_health.ToString(),ml);*/
		if (GUI.Button (new Rect (posx, posy, 100, 60), "STOP")) {
			Time.timeScale = 0; 
			Destroy (this.gameObject);
		}
		if (GUI.Button (new Rect (posx, posy, 100, 60), "START")) {
			Time.timeScale = 1; 
			Destroy (this.gameObject);
		}
		if (GUI.Button (new Rect (posx, posy, 100, 60), "HELP")) {
			Time.timeScale = 0; 
			Destroy (this.gameObject);
		}

	}
}
