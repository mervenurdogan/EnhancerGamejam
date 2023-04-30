using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cupgame : MonoBehaviour
{
    public GameObject CupCanva;
   // public GameObject _truecup;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CupCanva.SetActive(true);
            
        }
    }

}
