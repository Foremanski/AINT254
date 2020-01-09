using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudioOnForward : MonoBehaviour
{
    public AudioSource planetAttractor;

    
    // Update is called once per frame
    void Update()
    {
        //if player is moving and audiosource is not already playing and fuel hasn't ran out
        if (Input.GetKey("w") && 
            gameObject.GetComponent<FuelController>().FuelOut == false &&
            gameObject.GetComponent<AudioSource>().isPlaying == false) 
        {
            gameObject.GetComponent<AudioSource>().Play();
        }
  
        else if(!Input.GetKey("w"))
        {
            gameObject.GetComponent<AudioSource>().Stop();
        }


        //if played is being pulled in and gravity attractor sound isn't playing already
        if (gameObject.GetComponent<GravityController>().gravityAffecting == true && planetAttractor.isPlaying == false)
        {
            planetAttractor.Play();
        }

        if(gameObject.GetComponent<GravityController>().gravityAffecting == false)
        {
            planetAttractor.Stop();
        }

    }
}
