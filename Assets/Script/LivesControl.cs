using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesControl : MonoBehaviour
{
    public List<GameObject> LifeObjects = new List<GameObject>();
    public static bool IsGameover;
    private Scene _scene;


    //yanarsa belli noktaya geri dönecek(ýþýnlanacak)
    //can azalacak
    //can biterse game over?-baþlangýç ekraný
    private void Awake()
    {
        Counters.lives = 3;
        _scene = SceneManager.GetActiveScene();
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
    private void Gameisover()
    {
        SceneManager.LoadScene(_scene.buildIndex);
    }
    //public bool substractlife()
    //{
    //    Isdamaged= true;
    //    //sound eklenebilir
    //    //animasyon burada baþlayacak
    //    Counters.lives--;
    //    LifeObjects[Counters.lives].SetActive(false);
    //    Invoke("DamageEnded", 3.0f);
    //    return IsGameover = Counters.lives == 0;

    //}
    //void DamageEnded()
    //{
    //    //animasyon burada çalýþtýrýlacak
    //    Isdamaged = false;
    //}

}
