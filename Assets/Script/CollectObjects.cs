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
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("MadCollect"))
        {
            // ses ?audio.play?
            //madalyon say�s� artacak
            //madalyon yok olacak
            //1.madalyonda wood, 2.de ah�ap a��lacak, 3.de portal 
            Counters.madalyon++;
            _madtext.text = Counters.madalyon.ToString() + " /5";
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
            _woodtext.text = Counters.wood.ToString() + " /5";
            Debug.Log("odun topland�" + Counters.wood);
            if (Counters.wood == 3)
            {
                WoodBoat.SetActive(true);
            }

        }
        if (other.gameObject.CompareTag("RockCollect"))
        {
            Counters.stone++;
            Destroy(other.gameObject);
            _rocktext.text = Counters.stone.ToString() + " /5";
            if (Counters.stone == 3)
            {
                RockBridge.SetActive(true);
            }
        }


    }
    void OpenWood()
    {
        Debug.Log("woodlar a��ld�");
        WoodObjects.SetActive(true);
        //guide a��lacak,
        //woodlar a��lacak

    }
    void OpenRock()
    {
        Debug.Log("rocklar a��ld�");
        RockObjects.SetActive(true);
        //guide a��lacak
        //rocklar a��lacak
    }
    void OpenPortal()
    {
        Debug.Log("portal a��ld�");
        //portal a��lacak?
    }

}
