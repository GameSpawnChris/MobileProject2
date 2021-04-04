using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Threading;
using System.Diagnostics;

public class OnFire : MonoBehaviour
{

    public bool buttonFire = false;
    public float maxrayDistance = 100.0f;

    public void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.back);

        UnityEngine.Debug.DrawLine(transform.position, transform.position + Vector3.back * maxrayDistance, Color.red);

        if (Physics.Raycast(ray, out hit, maxrayDistance))
        {
            if (hit.transform != null && buttonFire == true)
            {
                PrintName(hit.transform.gameObject);
            }
        }
    }

    public void OnFireButton()
    {
        buttonFire = true;
    }

    private void PrintName(GameObject gameObject)
    {
        print(gameObject.name);
    }
}
