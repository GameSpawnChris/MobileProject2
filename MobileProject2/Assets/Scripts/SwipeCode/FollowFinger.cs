using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowFinger : MonoBehaviour
{
    private Vector3 mousePosition;
    public float moveSpeed = 100f;
    private Rigidbody rb;
    private Vector3 direction;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            direction = (mousePosition - transform.position).normalized;
            rb.velocity = new Vector3(direction.x * moveSpeed, direction.y * moveSpeed);
        }
        else 
        {
            rb.velocity = Vector3.zero; 
        }

    }
}
