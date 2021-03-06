﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
    public Slider FuelBar;
    private float FuelRemaining;
    public float maximumFuel = 500;
    public float fuelRegen;
    public bool FuelOut;

    public GameObject GameOver;
    public GameObject PauseMenu;

   // public float burnoutTime = 1;
   // private float timer = Time.deltaTime;


    //debug
    //=====================
    Vector3 originalPos;
    Rigidbody myRigidbody;
    //=====================

    // Start is called before the first frame update
    public void Start()
    {          
        FuelRemaining = maximumFuel;
        FuelOut = false;

        //===========================
        originalPos = gameObject.transform.position;
        myRigidbody = gameObject.GetComponent<Rigidbody>();
        //===========================
    }

    // Update is called once per frame
    void Update()
    {


        //stop moving player when fuel runs out 
        if(FuelRemaining == 0)
        {
            gameObject.GetComponent<PlayerMovement>().enabled = false;
            FuelOut = true;
            //for(timer = 0; timer <= burnoutTime; timer++)
           // {
           //     FuelRemaining = 0;
           // }
        }

        else if(Input.GetKey("w") && FuelRemaining != 0)
        {
            FuelRemaining -= 1;
            FuelBar.value = FuelRemaining;

            gameObject.GetComponent<PlayerMovement>().enabled = true;
        }



        //debug section 
        /*=======================
        if (Input.GetKey("space"))
        {
            gameObject.transform.position = originalPos;
            myRigidbody.velocity = new Vector3(0, 0, 0);
            FuelRemaining = maximumFuel;
            FuelBar.value = FuelRemaining;
        } 
        ======================= */
    }

    public void ResetLevel()
    {
        gameObject.transform.position = originalPos;
        myRigidbody.velocity = new Vector3(0, 0, 0);
        FuelRemaining = maximumFuel;
        FuelBar.value = FuelRemaining;
        gameObject.GetComponent<GravityController>().enabled = true;



    }
}
 