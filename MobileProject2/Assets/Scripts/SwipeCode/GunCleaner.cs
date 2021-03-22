using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunCleaner : MonoBehaviour
{
    public GameObject mask;
    bool pressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //pos.z = -6;

        if(pressed==true)
        {
            GameObject ob = Instantiate(mask, pos, Quaternion.identity);
            ob.transform.parent = GameObject.Find("GunCleaner").transform;
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
