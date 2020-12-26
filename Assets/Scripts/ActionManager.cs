using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    public bool isKeyPicked = false;
    public bool isDoorOpened = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isDoorOpened)
        {
            Debug.Log("~~~ Jew Won!!! ~~~");

        }

        if (isKeyPicked)
        {

        }
        
    }

}
