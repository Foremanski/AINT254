using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudioOnForward : MonoBehaviour
{ 
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
    }
}
