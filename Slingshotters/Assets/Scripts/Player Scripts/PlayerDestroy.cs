using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDestroy : MonoBehaviour
{
    Vector3 originalPos;
    public GameObject Player;

    void Start()
    {
        originalPos = Player.transform.position;
    }

    void OnTriggerEnter(Collider Player)
    {
        Player.transform.position = originalPos;
    }
}
