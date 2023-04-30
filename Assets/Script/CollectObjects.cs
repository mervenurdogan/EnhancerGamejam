using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectObjects : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _madtext;
    [SerializeField] private TextMeshProUGUI _woodtext;
    [SerializeField] private TextMeshProUGUI _rocktext;
    public GameObject WoodBoat;
    public GameObject Boatclosed;
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
            Counters.madalyon++;
            _madtext.text = Counters.madalyon.ToString() + " /3";
            Destroy(other.gameObject);
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

        if (other.gameObject.CompareTag("RockCollect"))
        {
            Counters.stone++;
            Destroy(other.gameObject);
            _rocktext.text = Counters.stone.ToString() + "/5";
            
        }

    }

    void OpenPortal()
    {
        Debug.Log("portal açýldý");
        //portal açýlacak?
    }

}
