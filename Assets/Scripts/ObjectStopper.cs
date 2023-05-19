using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectStopper : MonoBehaviour
{
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void OnMouseUp()
    {
        _rb.velocity = Vector3.zero;
    }
}
