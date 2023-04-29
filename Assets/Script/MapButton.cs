using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapButton : MonoBehaviour
{

    public GameObject MapUI;

    public void OpenMap()
    {
        MapUI.SetActive(true);
    }
    public void CloseMap()
    {
        MapUI.SetActive(false);
    }
}
