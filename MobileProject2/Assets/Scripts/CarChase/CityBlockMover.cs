using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityBlockMover : MonoBehaviour
{
    public BoxCollider2D objCollider;
    public Rigidbody2D rb;
    public float destoryPos;


    public float ObjectSpeed;

    // Start is called before the first frame update
    void Start()
    {
        objCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector3(ObjectSpeed, 0, 0);

    }

    private void Update()
    {
        if (transform.position.x <= destoryPos)
        {
            Destroy(gameObject);
        }
    }
}
