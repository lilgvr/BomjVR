using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Transform theDest;

    public bool SavePhysics;

    Rigidbody rb;
    BoxCollider bc;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        bc = GetComponent<BoxCollider>();
        theDest = GameObject.Find("Destination").transform;
    }

    private void OnMouseDown()
    {
        if (SavePhysics)
        {
            rb.isKinematic = true;
        }
        else
        {
            bc.enabled = false;
            rb.useGravity = false;
        }

        rb.angularVelocity = Vector3.zero;
        rb.velocity = Vector3.zero;
        transform.position = theDest.position;
        transform.parent = theDest.transform;
    }

    private void OnMouseUp()
    {
        transform.parent = null;
        if (SavePhysics)
        {
            rb.isKinematic = false;
        }
        else
        {
            bc.enabled = true;
            rb.useGravity = true;
        }
    }
}
