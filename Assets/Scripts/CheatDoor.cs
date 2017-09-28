using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (PlayMakerFSM))]
public class CheatDoor : MonoBehaviour 
{
	private PlayMakerFSM fsm;

	private void Awake ()
	{
		fsm = GetComponent<PlayMakerFSM> ();
	}

	private void Update () 
	{
		#if UNITY_EDITOR
		if (Input.GetKeyDown (KeyCode.C))
		{
			fsm.SendEvent ("open");
		}	
		#endif
	}
}
