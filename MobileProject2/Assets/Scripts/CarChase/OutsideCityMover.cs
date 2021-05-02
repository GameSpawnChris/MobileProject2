using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutsideCityMover : MonoBehaviour
{
    public BoxCollider objCollider;
    public Rigidbody rb;
    public float destoryPosX;


    public float ObjectSpeedX;

    // Start is called before the first frame update
    void Start()
    {
        objCollider = GetComponent<BoxCollider>();
        rb = GetComponent<Rigidbody>();

        rb.velocity = new Vector3(ObjectSpeedX, 0, 0);

    }

    private void Update()
    {
        if (transform.position.x <= destoryPosX)
        {
            Destroy(gameObject);
        }
    }
}
