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
            Destroy(other.gameObject); //dayýyýy sildik
          
        }

        if (other.gameObject.CompareTag("Marangoz"))
        {
            MarangozUI.SetActive(true);
            OpenWood();
            Destroy(other.gameObject); //dayýyýy sildik
            
        }

        if (other.gameObject.CompareTag("Yilan"))
        {
            if (Counters.stone == 0) //ilk karþýlaþma
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
            //köprüden gaçerken taþlarý kullandýðýmýz için UIyý kapatýyoruz
            RockUI.SetActive(false);
        }


        if (other.gameObject.CompareTag("Boat"))
        {
            //tekneden gaçerken ahþaplarý kullandýðýmýz için UIyý kapatýyoruz
            WoodUI.SetActive(false);
        }
    }

    void OpenWood()
    {
        Debug.Log("woodlar açýldý");
        WoodObjects.SetActive(true);
        WoodUI.SetActive(true);
        //guide açýlacak,
        //woodlar açýlacak

    }
    public void OpenRock()
    {
        Debug.Log("rocklar açýldý");
        RockObjects.SetActive(true);
        RockUI.SetActive(true);
        //guide açýlacak
        //rocklar açýlacak
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
