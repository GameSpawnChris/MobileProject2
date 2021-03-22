using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunCleaner : MonoBehaviour
{
    public GameObject mask;
    private bool pressed = false;


    // Update is called once per frame
    void Update()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = 1;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);


        if (pressed == true)
        {
            GameObject maskNob = Instantiate(mask, mousePos, Quaternion.identity);
            maskNob.transform.parent = gameObject.transform;
        } 
        else
        {

        }

        if (Input.GetMouseButtonDown(0))
        {
            pressed = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            pressed = false;
        }
    }
}
