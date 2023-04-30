using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CupCanva : MonoBehaviour
{
    public GameObject cupgame;
    //Start is called before the first frame update
    public void Findball()
    {
        // _truecup.SetActive(false);
        cupgame.SetActive(false);
        this.transform.parent.gameObject.SetActive(false);
        Debug.Log("ball found");
        //Destroy(gameObject);
        //destroy current object
    }
    //public void BallNotfound()
    //{
    //    Debug.Log("life substracted cupgame");
    //    //substractlife
    //}
}
