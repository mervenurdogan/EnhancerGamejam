using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portalwin : MonoBehaviour
{
    private Scene _scene2;
    private void Awake()
    {
        _scene2 = SceneManager.GetActiveScene();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Counters.madalyon ==3)
            {
                Debug.Log("next scene");
                SceneManager.LoadScene(_scene2.buildIndex + 1);

            }
        }

    }
}
