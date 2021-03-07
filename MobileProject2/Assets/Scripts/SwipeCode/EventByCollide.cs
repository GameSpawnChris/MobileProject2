using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventByCollide : MonoBehaviour
{

    public GameObject explosion;
    //public AudioSource audio;

    void Start()
    {
        //audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
                UnityEngine.Debug.Log("Dropped!");
                explosion.SetActive(true);
                //audio.Play();
        }
    }
}
