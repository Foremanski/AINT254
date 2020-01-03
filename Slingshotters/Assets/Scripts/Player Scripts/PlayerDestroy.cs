using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDestroy : MonoBehaviour
{
    public GameObject GameOverUI;

    void Start()
    {
        StartSetup();
    }

    public void StartSetup()
    {
        GameOverUI.SetActive(false);
        Time.timeScale = 1;

        gameObject.GetComponent<GravityController>().enabled = true;
    }

    void OnTriggerEnter(Collider Planet)
    {
        if(Planet.tag == "Planet")
        {
            GameOverUI.SetActive(true);

            gameObject.GetComponent<GravityController>().enabled = false;

            Time.timeScale = 0;
        }                 
    }   
}
