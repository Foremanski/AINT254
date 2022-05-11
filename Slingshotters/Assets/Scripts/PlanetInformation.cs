using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetInformation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float planetDistance;
    public bool inRange;

    void Start()
    {
        inRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float getPlanetDistance()
    {
        return planetDistance;
    }
}
