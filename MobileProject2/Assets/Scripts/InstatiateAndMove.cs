using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstatiateAndMove : MonoBehaviour
{
    public Rigidbody2D building;
    public float moveSpeed;

    public Vector2 move;

    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        building.velocity = new Vector2(moveSpeed, 0);
    }
}
