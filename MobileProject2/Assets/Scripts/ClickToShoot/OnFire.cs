using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Threading;
using System.Diagnostics;

public class OnFire : MonoBehaviour
{
    //public GameObject firePosition;
    //public Vector3 crossHairCenter;
    
    public float maxrayDistance = 100.0f;

    public void OnFireButton()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.down);

        UnityEngine.Debug.DrawLine(transform.position, transform.position + Vector3.left * maxrayDistance, Color.red);

        if (Physics.Raycast(ray, out hit, maxrayDistance))
        {
            if (hit.transform != null)
            {
                PrintName(hit.transform.gameObject);
            }
        }
    }

    private void PrintName(GameObject gameObject)
    {
        print(gameObject.name);
    }

   
}
