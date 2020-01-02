using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuHandler : MonoBehaviour
{
    public GameObject LevelSelect;
    

    // Start is called before the first frame update
    void Start()
    {
        backtoMenu();
    }

    public void backtoMenu()
    {
        LevelSelect.SetActive(false);
    }

    public void toLevelSelect()
    {
        LevelSelect.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
