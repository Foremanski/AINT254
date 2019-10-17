using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 originalPos;
    
    // Start is called before the first frame update
    void Start()
    {
        originalPos = gameObject.transform.position;

    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hazard")
        {
            gameObject.transform.position = originalPos;
        }
    }
}
