using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onGoalPass : MonoBehaviour
{
    public GameObject Player;
    public string nextLevel;
    public GameObject levelComplete;
    public GameObject Audio;
    public GameObject BlurBackground;

    // Start is called before the first frame update
    void Start()
    {
        levelComplete.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider Player)
    {
        //prevent player from accessing escape menu
        Player.GetComponent<EscMenu>().enabled = false;
        Time.timeScale = 0;

        BlurBackground.SetActive(true);

        //slow down music
        Audio.GetComponent<AudioSource>().pitch = 0.9f;
        Audio.GetComponent<AudioSource>().volume = 0.5f;

        //enable finish UI
        levelComplete.SetActive(true);        
    }

    public void nextScene()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
