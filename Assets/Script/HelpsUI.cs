using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpsUI : MonoBehaviour
{
    //pencerey kapat
    //timescale=1 yap
    public GameObject DayiUI;
    public GameObject MarangozUI;
    public GameObject YilanUI;
    public GameObject YilanUIAA;
    public GameObject YilanUI2;
    public GameObject _Marangozz;
    public HelpManager _script;


    public void CloseDayiUI()
    {
        //close tab� anim i�in de trigger. anim oynay�nca kapanacak?
        DayiUI.SetActive(false);
        _Marangozz.SetActive(true);

    }
    public void CloseMarangozUI()
    {
        MarangozUI.SetActive(false);
        
    }
    public void CloseYilanUI()
    {
        YilanUI.SetActive(false);
        Time.timeScale = 1;
    }
    public void CloseYilanUIAA()
    {
        YilanUIAA.SetActive(false);
        Time.timeScale = 1;
    }
    public void CloseYilanUI2()
    {
        YilanUI2.SetActive(false);
        Time.timeScale = 1;
    }
    public void DogruCevap()
    {
        _script.OpenRock();
        YilanUI.SetActive(false);
        YilanUIAA.SetActive(true);

        //ta�lar a��lacak 
    }
    public void DogruCevap2()
    {
        _script.OpenBridge();
        Time.timeScale = 1;
        YilanUI2.SetActive(false);
        
        //k�pr� a��lacak
    }
    public void YanlisCevap()
    {
        _script.SubstractLife();
        //can azalacak
        //yanl�� buton k�rm�z� olacak
    }

}
