using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanerPointDetect : MonoBehaviour
{
    public bool cleanPoint1;
    public bool cleanPoint2;
    public bool cleanPoint3;

    public GameObject newPhase;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cleanPoint1 == true && cleanPoint2 == true && cleanPoint3 == true)
        {
            UnityEngine.Debug.Log("DONE!");
            newPhase.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "CleanPoint1")
        {
            cleanPoint1 = true;
            UnityEngine.Debug.Log("CleanPoint1");
        }

        if (collider.gameObject.tag == "CleanPoint2")
        {
            cleanPoint2 = true;
            UnityEngine.Debug.Log("CleanPoint2");
        }

        if (collider.gameObject.tag == "CleanPoint3")
        {
            cleanPoint3 = true;
            UnityEngine.Debug.Log("CleanPoint3");
        }
    }
}
