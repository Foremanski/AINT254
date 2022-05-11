﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float rotSpeed = 3;
    public float moveSpeed = 10f;
    Rigidbody myRigidbody;

    void Start()
    {
        myRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {       

        if(Input.GetKey("a"))
        {
            myRigidbody.AddTorque(new Vector3(0, -1, 0) * rotSpeed);
            gameObject.GetComponent<PlayPlayerEffect>().TurnLeftEffect();
        }
     
        else if (Input.GetKey("d"))
        {
            myRigidbody.AddTorque(new Vector3(0, 1, 0) * rotSpeed);

            gameObject.GetComponent<PlayPlayerEffect>().TurnRightEffect();

        }

        else if (Input.GetKey("w"))
        {
            myRigidbody.AddRelativeForce(new Vector3(0, 0, 1) * moveSpeed);

            gameObject.GetComponent<PlayPlayerEffect>().GoForwardEffect();

        }
        else
        {
            gameObject.GetComponent<PlayPlayerEffect>().StopEffect();
        }

    }
}
