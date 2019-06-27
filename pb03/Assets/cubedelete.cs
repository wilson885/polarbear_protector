using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class cubedelete : MonoBehaviour
{
	[SerializeField] private AudioSource soundsource;
	[SerializeField] private AudioClip lose;
	public bearanimator _bd;
	public SerialPort sp=new SerialPort ("/dev/cu.usbmodem1411",9600);
	public void Start ()
	{
		sp.Open();
		StartCoroutine (delete ());
	}

	private IEnumerator delete ()
	{
		
		yield return new WaitForSeconds (8);
		soundsource.PlayOneShot (lose);
		yield return new WaitForSeconds (2);
		if (sp.IsOpen) {
			sp.Write ("1");
			print (1);
		}
		Destroy (this.gameObject);
	}

	public void deleterightnow ()
	{
		Destroy (this.gameObject);
	}

	public void sve ()
	{
		_bd.bearsave ();
	}

	public void notsve ()
	{
		_bd.bearnotsave ();
	}
}
