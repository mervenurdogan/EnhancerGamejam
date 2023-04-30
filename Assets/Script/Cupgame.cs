using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cupgame : MonoBehaviour
{
    public GameObject CupCanva;
    public HelpManager _helpmanager;
   // public GameObject _truecup;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CupCanva.SetActive(true);
            
        }

    }
    public void Findball()
    {
       // _truecup.SetActive(false);
        CupCanva.SetActive(false);
        Debug.Log("ball found");
        //Destroy(gameObject);
        //destroy current object
    }
    public void BallNotfound()
    {
        CupCanva.SetActive(false);
        Debug.Log("life substracted cupgame");
        //substractlife
    }
}
