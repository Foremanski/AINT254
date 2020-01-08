using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDestroy : MonoBehaviour
{
    public GameObject GameOverUI;
    public GameObject BackgroundBlur;
    public AudioSource ShipExplode;

    void Start()
    {
        StartSetup();
    }

    public void StartSetup()
    {
        GameOverUI.SetActive(false);
        BackgroundBlur.SetActive(false);
        Time.timeScale = 1;

        gameObject.GetComponent<GravityController>().enabled = true;
        gameObject.GetComponent<EscMenu>().enabled = true;
    }

    void OnTriggerEnter(Collider Planet)
    {
        if(Planet.tag == "Planet")
        {
            GameOverUI.SetActive(true);
            BackgroundBlur.SetActive(true);
            ShipExplode.Play();

            gameObject.GetComponent<GravityController>().enabled = false;
            gameObject.GetComponent<EscMenu>().enabled = false;

            Time.timeScale = 0;
        }                 
    }   
}
