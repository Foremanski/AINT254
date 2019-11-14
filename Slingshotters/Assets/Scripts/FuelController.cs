using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
    public Slider FuelBar;
    public float FuelRemaining;
    public float maximumFuel = 100;

    // Start is called before the first frame update
    public void Start()
    {
        FuelRemaining = maximumFuel;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up"))
        {
            
        }
    }
}
