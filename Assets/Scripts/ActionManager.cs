using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public static bool isKeyPicked = false;
    public static bool isDoorOpened = false;

    public bool isDoorOpanable = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

	public static void IsGameWon()
    { 
        Debug.Log("~~~ Jew Won!!! ~~~");
    }
}
