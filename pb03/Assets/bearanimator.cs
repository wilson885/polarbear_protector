using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearanimator : MonoBehaviour {
	public Animator _animator;
	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator>();
	}
	public void bearsave()
	{
		_animator.SetBool("save",true);
	}
	public void bearnotsave()
	{
		_animator.SetBool("save",false);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
