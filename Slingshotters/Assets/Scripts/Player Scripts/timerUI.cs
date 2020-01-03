using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerUI : MonoBehaviour
{

    public GameObject textUI;
    float counter;

    bool playerActive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerActive == true)
        {
            counter += Time.deltaTime;
        }

        textUI.GetComponent<UnityEngine.UI.Text>().text = counter.ToString("#.00");
    }
}
