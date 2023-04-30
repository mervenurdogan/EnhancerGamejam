using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HelpManager : MonoBehaviour
{
    public GameObject DayiUI;
    public GameObject MarangozUI;
    public GameObject YilanUI;
    public GameObject YilanUI2;


    public GameObject WoodUI;
    public GameObject WoodObjects;

    public GameObject RockObjects;
    public GameObject RockUI;

    public GameObject RockBridge;
    public GameObject bridgeclosed;

    private Scene _scene;
    public List<GameObject> LifeObjects = new List<GameObject>();
    private bool yilanilkmi = false;

    private void Awake()
    {
        Counters.lives = 3;
        _scene = SceneManager.GetActiveScene();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Dayi"))
        {
            DayiUI.SetActive(true);
            Destroy(other.gameObject); //day�y�y sildik
          
        }

        if (other.gameObject.CompareTag("Marangoz"))
        {
            MarangozUI.SetActive(true);
            OpenWood();
            Destroy(other.gameObject); //day�y�y sildik
            
        }

        if (other.gameObject.CompareTag("Yilan"))
        {
            if (Counters.stone == 0) //ilk kar��la�ma
            {
                YilanUI.SetActive(true);
                Time.timeScale = 0;
                
            }

            else if (Counters.stone == 5 && !yilanilkmi) //ikinci
            {
                
                YilanUI2.SetActive(true);
                Time.timeScale = 0;

            }

        }

        if (other.gameObject.CompareTag("Bridge"))
        {
            //k�pr�den ga�erken ta�lar� kulland���m�z i�in UIy� kapat�yoruz
            RockUI.SetActive(false);
        }


        if (other.gameObject.CompareTag("Boat"))
        {
            //tekneden ga�erken ah�aplar� kulland���m�z i�in UIy� kapat�yoruz
            WoodUI.SetActive(false);
        }
    }

    void OpenWood()
    {
        Debug.Log("woodlar a��ld�");
        WoodObjects.SetActive(true);
        WoodUI.SetActive(true);
        //guide a��lacak,
        //woodlar a��lacak

    }
    public void OpenRock()
    {
        Debug.Log("rocklar a��ld�");
        RockObjects.SetActive(true);
        RockUI.SetActive(true);
        //guide a��lacak
        //rocklar a��lacak
    }
    public void OpenBridge()
    {
            RockBridge.SetActive(true);
            bridgeclosed.SetActive(false);
            yilanilkmi = true;
    }
    public void SubstractLife()
    {
        if (Counters.lives > 0 && Counters.lives <= 3)
        {
            Counters.lives--;
            
            LifeObjects[Counters.lives].SetActive(false);
            Time.timeScale = 1;
            YilanUI.SetActive(false);
            YilanUI2.SetActive(false);
            if (Counters.lives == 0)
            {
                SceneManager.LoadScene(_scene.buildIndex);
                //gameover
            }

        }
        

    }
}
