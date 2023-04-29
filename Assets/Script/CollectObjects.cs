using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CollectObjects : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _madtext;
    [SerializeField] private TextMeshProUGUI _woodtext;
    [SerializeField] private TextMeshProUGUI _rocktext;
    public GameObject WoodObjects;
    public GameObject RockObjects;
    public GameObject WoodBoat;
    public GameObject RockBridge;
    public GameObject WoodUI;
    public GameObject RockUI;
    public GameObject Boatclosed;
    public GameObject bridgeclosed;
    private void Awake()
    {
        Counters.madalyon = 0;
        Counters.wood = 0;
        Counters.stone = 0;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("MadCollect"))
        {
            // ses ?audio.play?
            //madalyon sayýsý artacak
            //madalyon yok olacak
            //1.madalyonda wood, 2.de ahþap açýlacak, 3.de portal 
            Counters.madalyon++;
            _madtext.text = Counters.madalyon.ToString() + " /3";
            Destroy(other.gameObject);
            switch (Counters.madalyon)
            {
                case 3:
                    OpenPortal();
                    break;
                case 2:
                    OpenRock();
                    break;
                case 1:
                    OpenWood();
                    break;
                default:
                    break;
            }

        }
        if (other.gameObject.CompareTag("WoodCollect"))
        {
            Counters.wood++;
            Destroy(other.gameObject);
            _woodtext.text = Counters.wood.ToString() + "/3";
            Debug.Log("odun toplandý" + Counters.wood);
            if (Counters.wood == 3)
            {
                WoodBoat.SetActive(true);
                Boatclosed.SetActive(false);
                
            }

        }

        if (other.gameObject.CompareTag("Boat"))
        {
            WoodUI.SetActive(false);
        }

        if (other.gameObject.CompareTag("RockCollect"))
        {
            Counters.stone++;
            Destroy(other.gameObject);
            _rocktext.text = Counters.stone.ToString() + "/5";
            if (Counters.stone == 5)
            {
                RockBridge.SetActive(true);
                bridgeclosed.SetActive(false);
               
            }
        }
        if (other.gameObject.CompareTag("Bridge"))
        {
            RockUI.SetActive(false);

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
    void OpenRock()
    {
        Debug.Log("rocklar açýldý");
        RockObjects.SetActive(true);
        RockUI.SetActive(true);
        //guide açýlacak
        //rocklar açýlacak
    }
    void OpenPortal()
    {
        Debug.Log("portal açýldý");
        //portal açýlacak?
    }

}
