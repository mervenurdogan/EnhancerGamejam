using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesControl : MonoBehaviour
{
    public List<GameObject> LifeObjects = new List<GameObject>();
    public static bool IsGameover;

    //yanarsa belli noktaya geri d�necek(���nlanacak)
    //can azalacak
    //can biterse game over?-ba�lang�� ekran�
    private void Awake()
    {
        Counters.lives = 3;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy")) 
        {
            Debug.Log("UIlar gelecek");
            //if (Counters.lives > 0 && Counters.lives <= 3)
            //{
            //    //substractlife();

            //}
        }
        
    }
    //public bool substractlife()
    //{
    //    Isdamaged= true;
    //    //sound eklenebilir
    //    //animasyon burada ba�layacak
    //    Counters.lives--;
    //    LifeObjects[Counters.lives].SetActive(false);
    //    Invoke("DamageEnded", 3.0f);
    //    return IsGameover = Counters.lives == 0;

    //}
    //void DamageEnded()
    //{
    //    //animasyon burada �al��t�r�lacak
    //    Isdamaged = false;
    //}
}
