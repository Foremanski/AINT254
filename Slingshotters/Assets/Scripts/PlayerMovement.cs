using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    float rotSpeedStart = 0;
    float rotSpeed = 3;
    float moveSpeedStart = 0;
    float moveSpeed = 10f;
    Rigidbody myRigidbody;
    ParticleSystem particleSystemRight;

    Vector3 originalPos;


    void Start()
    {
        originalPos = gameObject.transform.position;
        myRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {       

        if(Input.GetKey("left"))
        {
            myRigidbody.AddTorque(new Vector3(0, -1, 0) * rotSpeed);
            
        }
     
        else if (Input.GetKey("right"))
        {
            myRigidbody.AddTorque(new Vector3(0, 1, 0) * rotSpeed);
        }

        else if (Input.GetKey("up"))
        {
            myRigidbody.AddRelativeForce(new Vector3(1, 0, 0) * moveSpeed);
           
        }

        else if (Input.GetKey("space") == true)
        {
            gameObject.transform.position = originalPos;
            myRigidbody.velocity = new Vector3(0, 0, 0);
        }
    }
}
