using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public GameObject Player;

    //planet's gravity field
    public float maxDistance;
    GameObject[] Planet;
    //public AudioSource planetAttractor;
    public bool gravityAffecting;
    private Rigidbody playerRigidbody;

    void Start()
    {
        playerRigidbody = Player.GetComponent<Rigidbody>();
        Planet = GameObject.FindGameObjectsWithTag("Planet");
    }

    void Update()
    {
        for(int i = 0; i < Planet.Length; i++)
        {          
            float Distance = Vector3.Distance(Player.transform.position, Planet[i].transform.position);
            Rigidbody planetRigidbody = Planet[i].GetComponent<Rigidbody>();

            //gravitional constant
            float G = 6.674f;
            //formula 
            float gravityFormula = (G * ((playerRigidbody.mass * planetRigidbody.mass) / (Distance * Distance)));

            //if player is close enough
            if (Distance < maxDistance)
            {
                //add fov while in gravity well
                if(Camera.main.fieldOfView < 90)
                {
                    Camera.main.fieldOfView += 0.01f;
                }              
                gravityAffecting = true;

                //add force to player in direction of planet
                playerRigidbody.AddForce((Planet[i].transform.position - Player.transform.position).normalized * gravityFormula);
            }

            //returns FOV to normal out of gravity well
            else
            {
                if (Camera.main.fieldOfView >= 56.2f)
                {
                    Camera.main.fieldOfView -= 0.1f;
                }
                //stop sound
                gravityAffecting = false;
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
