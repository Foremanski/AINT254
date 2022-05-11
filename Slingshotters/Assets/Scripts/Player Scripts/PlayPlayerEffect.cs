using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayPlayerEffect : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem leftTurnSteam, leftTurnFlame, rightTurnSteam, rightTurnFlame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GoForwardEffect()
    {
        leftTurnSteam.Play();
        leftTurnFlame.Play();

        rightTurnSteam.Play();
        rightTurnFlame.Play();
    }

    public void TurnLeftEffect()
    {
        leftTurnSteam.Play();
        leftTurnFlame.Play();
    }

    public void TurnRightEffect()
    {
        rightTurnSteam.Play();
        rightTurnFlame.Play();
    }

    public void StopEffect()
    {
        leftTurnSteam.Stop();
        leftTurnFlame.Stop();
        rightTurnSteam.Stop();
        rightTurnFlame.Stop();
    }
}
