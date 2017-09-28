using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Collider2D))]
public class DestroyOnTriggerEnter : MonoBehaviour 
{
	private void OnTriggerEnter2D (Collider2D collider)
	{
		Destroy (gameObject);
	}
}
