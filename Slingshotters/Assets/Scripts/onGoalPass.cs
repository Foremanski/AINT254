using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class onGoalPass : MonoBehaviour
{
    public GameObject Player;
    public string nextLevel;
    public GameObject levelComplete;

    public AudioSource MusicAudio;
    public AudioSource GoalReached;

    public GameObject BackgroundBlur;

    public GameObject Timer;
    public GameObject FinalTime;

    // Start is called before the first frame update
    void Start()
    {
        levelComplete.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //prevent player from accessing escape menu
        Player.GetComponent<EscMenu>().enabled = false;
        Time.timeScale = 0;

        BackgroundBlur.SetActive(true);

        FinalTime.GetComponent<UnityEngine.UI.Text>().text = Timer.GetComponent<UnityEngine.UI.Text>().text;

        GoalReached.Play();

        //slow down music
        MusicAudio.pitch = 0.9f;
        MusicAudio.volume = 0.5f;

        //enable finish UI
        levelComplete.SetActive(true);        
    }

    public void nextScene()
    {
        SceneManager.LoadScene(nextLevel);
    }
}
