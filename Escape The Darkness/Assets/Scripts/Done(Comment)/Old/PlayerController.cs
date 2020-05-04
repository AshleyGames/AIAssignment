using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour {

    public float movementForce = 1f;
    

    void Update()
    {
        var rigidBody = GetComponent<Rigidbody>();



        rigidBody.AddForce(transform.forward * movementForce * -Input.GetAxis("Horizontal"), ForceMode.Impulse);
        rigidBody.AddForce(transform.right * movementForce * Input.GetAxis("Vertical"), ForceMode.Impulse);

        if (Input.GetButtonDown("Jump"))
        {
            rigidBody.AddForce(Vector3.up * 20, ForceMode.Impulse);
        }

        
    }
}

