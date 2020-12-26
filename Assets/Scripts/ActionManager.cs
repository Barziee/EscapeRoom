using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public static bool isKeyPicked = false;
    public static bool isDoorOpened = false;

	public static void IsGameWon()
    { 
        Debug.Log("You Won");
    }
}
