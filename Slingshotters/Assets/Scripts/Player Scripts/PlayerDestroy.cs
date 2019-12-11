using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDestroy : MonoBehaviour
{
    Vector3 originalPos;

    void Start()
    {
        originalPos = gameObject.transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if(gameObject.tag == "Planet")
        {
            Debug.Log("Oh No!");
            gameObject.transform.position = originalPos;
            
        }
    }
}
