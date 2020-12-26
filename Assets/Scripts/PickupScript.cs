using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupScript : MonoBehaviour
{
    GameObject pickedObject;
    public GameObject KeySprite;

    ActionManager actionManager;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Object")
                {
                    var tmpObj = hit.collider.gameObject;
                    Destroy(tmpObj);


                    KeySprite.SetActive(true);
                    ActionManager.isKeyPicked = true;
                }

            }

        }

    }

}
