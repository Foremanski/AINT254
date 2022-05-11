using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody playerRigidbody;
    
    GameObject[] Planet;    
    private Rigidbody currentPlanetRigidbody;

    //gravitational constant
    private float G;
    //distance between player and planet
    private float currentDistance;   
    //gravity effect currently being applied
    private float currentGravityEffect;

    void Start()
    {
        //get player rigidbody
        playerRigidbody = Player.GetComponent<Rigidbody>();
        //get all Planets
        Planet = GameObject.FindGameObjectsWithTag("Planet");
        //set constant
        G = 6.674f;
    }

    void Update()
    {
        UpdatePlayerGravity();
    }

    void UpdatePlayerGravity()
    {
        for (int i = 0; i < Planet.Length; i++)
        {
            GetPlanetData(Planet[i]);
            AddPlanetForce(Planet[i]);
        }
        //CheckAudioState();
    }

    void GetPlanetData(GameObject currentPlanet)
    {
        currentDistance = Vector3.Distance(Player.transform.position, currentPlanet.transform.position);
        currentPlanetRigidbody = currentPlanet.GetComponent<Rigidbody>();

        //formula 
        currentGravityEffect = (G * ((playerRigidbody.mass * currentPlanetRigidbody.mass) / (currentDistance * currentDistance)));
    }

    void AddPlanetForce(GameObject currentPlanet)
    {
        //if player is within planet's range
        if (currentDistance < currentPlanet.GetComponent<PlanetInformation>().getPlanetDistance())
        {
            //add fov while in gravity well
            if (Camera.main.fieldOfView < 90)
            {
                Camera.main.fieldOfView += 0.01f;
            }
            //play audio
            if(!currentPlanet.GetComponent<AudioSource>().isPlaying)
            {
                currentPlanet.GetComponent<AudioSource>().Play();
            }
            //add force to player in direction of planet
            playerRigidbody.AddForce((currentPlanet.transform.position - Player.transform.position).normalized * currentGravityEffect);
        }

        //returns FOV to normal out of gravity well
        else
        {
            if (Camera.main.fieldOfView >= 56.2f)
            {
                Camera.main.fieldOfView -= 0.1f;
            }
            //play audio
            if (currentPlanet.GetComponent<AudioSource>().isPlaying)
            {
                currentPlanet.GetComponent<AudioSource>().Stop();
            }
        }
    }

}
