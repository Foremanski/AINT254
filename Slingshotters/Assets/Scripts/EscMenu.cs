using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscMenu : MonoBehaviour
{
    bool isPaused;
    public GameObject PauseMenu;
    public GameObject BlurBackground;
    public GameObject Audio;

    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        PauseMenu.SetActive(false);
        BlurBackground.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            //PauseMenu();
            ChangeMenu(isPaused);
        }

       /* else if (Input.GetKey(KeyCode.Escape) && isPaused == true)
        {
            UnpauseMenu();
        } */
    }

    void ChangeMenu(bool _value)
    {
        if (_value)
        {
            //Debug.Log("Yes");
            Time.timeScale = 0;
            gameObject.GetComponent<GravityController>().enabled = false;
            PauseMenu.SetActive(true);
            BlurBackground.SetActive(true);

            Audio.GetComponent<AudioSource>().pitch = 0.9f;
            Audio.GetComponent<AudioSource>().volume = 0.5f;
        }

        else
        {
            //Debug.Log("No");
            Time.timeScale = 1;
            gameObject.GetComponent<GravityController>().enabled = true;
            PauseMenu.SetActive(false);
            BlurBackground.SetActive(false);

            Audio.GetComponent<AudioSource>().pitch = 1;
            Audio.GetComponent<AudioSource>().volume = 1;
        }

        

        //void PauseMenu()
        //{
        //    Debug.Log("STOP");
        //    Time.timeScale = 0;
        //}

        //void UnpauseMenu()
        //{
        //    Debug.Log("UNSTOP");
        //    Time.timeScale = 1;
        //}
    }
}
