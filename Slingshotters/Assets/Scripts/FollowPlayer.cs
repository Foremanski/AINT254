using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float cameraHeight = 50.0f;
   
    // Update is called once per frame
    void Update()
    {
        Vector3 pos = player.transform.position;
        pos.y += cameraHeight;
        transform.position = pos;
    }
}
