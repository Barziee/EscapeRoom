using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{



	private void OnMouseDown()
	{
		if(ActionManager.isKeyPicked == true)
		{
			ActionManager.isDoorOpened = true;
		}

		if (ActionManager.isDoorOpened == true)
		{
			ActionManager.IsGameWon();
		}
	}
}
