using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverCityMover : MonoBehaviour
{
    public BoxCollider objCollider;
    public Rigidbody rb;
    public float destoryPosZ;


    public float ObjectSpeedZ;

    // Start is called before the first frame update
    void Start()
    {
        objCollider = GetComponent<BoxCollider>();
        rb = GetComponent<Rigidbody>();

        rb.velocity = new Vector3(0, 0, ObjectSpeedZ);

    }

    private void Update()
    {
        if (transform.position.z <= destoryPosZ)
        {
            Destroy(gameObject);
        }
    }
}
