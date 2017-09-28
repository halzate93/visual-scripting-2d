using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Collider2D))]
public class SimpleOpenDoor : MonoBehaviour 
{
	[SerializeField]
	private Rigidbody2D door;
	[SerializeField]
	private float verticalMovement = 1f;

	private void OnTriggerEnter2D (Collider2D collider)
	{
		Vector2 targetPosition = door.position + Vector2.up * verticalMovement;
		door.MovePosition (targetPosition);
	}
}
