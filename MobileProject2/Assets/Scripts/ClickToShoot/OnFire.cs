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
    public float maxrayDistance = 50.0f;

    public void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, Vector3.back);

        UnityEngine.Debug.DrawLine(transform.position, transform.position + Vector3.back * maxrayDistance, Color.red);

        if (Physics.Raycast(ray, out hit, maxrayDistance))
        {
            if (hit.transform != null && buttonFire == true)
            {
                //hitDetect(hit.transform.gameObject);
                StartCoroutine(hitDetection(hit.transform.gameObject));
            }
        }
    }

    public void OnFireButton()
    {
        buttonFire = true;
    }

    IEnumerator hitDetection(GameObject gameObject)
    {
        if (gameObject.tag == "Enemy")
        {
            UnityEngine.Debug.Log("Enemy (:");
        }
        else
        {
            UnityEngine.Debug.Log("Friend ):");
        }

        yield return new WaitForSeconds(0.001f);

        buttonFire = false;

    }

   /* private void hitDetect(GameObject gameObject)
    {
        if (gameObject.tag == "Enemy")
        {
            UnityEngine.Debug.Log("Enemy (:");
        } 
        else
        {
            UnityEngine.Debug.Log("Friend ):");
        }

    }
    */
}
