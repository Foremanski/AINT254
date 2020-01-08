using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemHandler : MonoBehaviour
{
    public GameObject particleSystemForward;
    public GameObject particleSystemLeft;
    public GameObject particleSystemRight;

    private void Start()
    {
        particleSystemForward.SetActive(false);
        particleSystemLeft.SetActive(false);
        particleSystemRight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        //turn on animations
        if(Input.GetKey("w"))
        {
            particleSystemForward.SetActive(true);
        }
        if (Input.GetKey("a"))
        {
            particleSystemLeft.SetActive(true);
        }
        if (Input.GetKey("d"))
        {
            particleSystemRight.SetActive(true);
        }

        //turn off animations 
        if (!Input.GetKey("w"))
        {
            particleSystemForward.SetActive(false);
        }
        if (!Input.GetKey("a"))
        {
            particleSystemLeft.SetActive(false);
        }
        if (!Input.GetKey("d"))
        {
            particleSystemRight.SetActive(false);
        }

    }
}
