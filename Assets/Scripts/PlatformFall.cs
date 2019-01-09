using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformFall : MonoBehaviour
{

	public float fallFelay = 1f;

	private Rigidbody2D rb2d;
	
	void Start ()
	{

		rb2d = GetComponent<Rigidbody2D>();
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Invoke("Fall", fallFelay);
		}
	}

	void Fall()
	{
		rb2d.bodyType = RigidbodyType2D.Dynamic;
	}
}
