using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketController : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 LastFrameVelocity;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        LastFrameVelocity = rb.velocity;
    }
}
