using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    float rotSpeedStart = 0;
    float rotSpeed = 10;
    float moveSpeedStart = 0;
    float moveSpeed = 0.1f;
    Rigidbody myRigidbody;

    Vector3 originalPos;

    float acceleration = 0.000000001f;

    void Start()
    {
        originalPos = gameObject.transform.position;
        myRigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float translationF = Input.GetAxis("Vertical") * moveSpeed;
        float translationR = Input.GetAxis("Horizontal") * rotSpeed;

        

        if(Input.GetKey("left") && (rotSpeedStart < rotSpeed))
        {
            rotSpeedStart = rotSpeedStart - acceleration * Time.deltaTime;
        }
        else if (Input.GetKey("right") && (rotSpeedStart < rotSpeed))
        {
            rotSpeedStart = rotSpeedStart - acceleration * Time.deltaTime;
        }

        else if (Input.GetKey("up") && (moveSpeedStart < moveSpeed))
        {
            moveSpeedStart = moveSpeedStart - acceleration * Time.deltaTime;
        }

        else if (Input.GetKey("space") == true)
        {
            gameObject.transform.position = originalPos;
            myRigidbody.velocity = new Vector3(0, 0, 0);
        }

        transform.Translate(translationF, 0, 0);

        transform.Rotate(0, translationR, 0);
    }
}
