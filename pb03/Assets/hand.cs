using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour {
	private Animator _animator;
	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			_animator.SetBool ("catch", true);
		} else
			_animator.SetBool ("catch", false);

	}
	public void _catch()
	{
		_animator.SetBool ("catch", true);
	}
	public void _notcatch()
	{
		_animator.SetBool ("catch", false);
	}
}
