using UnityEngine;

public class DoorScript : MonoBehaviour
{
	private void OnMouseDown()
	{
		if(ActionManager.isKeyPicked == true)
		{
			ActionManager.isDoorOpened = true;
			Debug.Log("Door unlocked");
		}

		if(ActionManager.isKeyPicked == false)
        {
			Debug.Log("Door is locked");
        }

		if (ActionManager.isDoorOpened == true)
		{
			ActionManager.IsGameWon();
		}
	}
}
