﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public GameObject Player;

    //planet's gravity field
    public float maxDistance;
    GameObject[] Planet;

    void Start()
    {
        
         Planet = GameObject.FindGameObjectsWithTag("Planet");
    }

    void Update()
    {
        for(int i = 0; i < Planet.Length; i++)
        {
            float Distance = Vector3.Distance(Player.transform.position, Planet[i].transform.position);

            Rigidbody playerRigidbody = Player.GetComponent<Rigidbody>();
            Rigidbody planetRigidbody = Planet[i].GetComponent<Rigidbody>();

            //gravitional constant
            float G = 6.674f;
            //newtons gravitional formula 
            float gravityFormula = (G * ((playerRigidbody.mass * planetRigidbody.mass) / (Distance * Distance)));

            //if the distance between player and planet is under the planet's gravity field
            if (Distance < maxDistance)
            {
                playerRigidbody.AddForce((Planet[i].transform.position - Player.transform.position).normalized * gravityFormula);
            }
        }
      
        //-------------------------------------------------------------------
        //Old Code Below
        //--------------------------------------------------------------------
        /*
        //creates an array of rigidbodies to apply gravity to
        Rigidbody[] Rigidbodies = FindObjectsOfType(typeof(Rigidbody)) as Rigidbody[];

            for (int x = 0; x < Rigidbodies.Length; x++)
            {
                for (int y = 0; y < Rigidbodies.Length; y++)
                {
                    if (x != y)
                    {
                        Rigidbodies[x].AddForce((Rigidbodies[y].gameObject.transform.position
                        - Rigidbodies[x].transform.position)
                        * (Rigidbodies[y].mass
                        / Vector3.Distance(Rigidbodies[x].transform.position, Rigidbodies[y].transform.position)));

                        if (Rigidbodies[x].velocity.magnitude > 100)
                        {
                            
                        }

                        // if(Rigidbodies[x])
                        //  {
                        //     Rigidbodies[x].AddForce(Rigidbodies[x].velocity * 3);
                        //     Rigidbodies[y].AddForce(Rigidbodies[y].velocity * 3);
                        // }

                    }

                    //checks to see if the rigidbody is close to the planet 

                }
            }  */    
    }
}
