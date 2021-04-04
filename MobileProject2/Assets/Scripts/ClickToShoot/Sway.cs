﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sway : MonoBehaviour
{
    public Vector3 pointA = new Vector3(0, 0, 0);
    public Vector3 pointB = new Vector3(1, 1, 1);
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}
