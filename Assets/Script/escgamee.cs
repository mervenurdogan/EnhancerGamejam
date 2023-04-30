using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escgamee : MonoBehaviour
{
    //escye basarsa

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
