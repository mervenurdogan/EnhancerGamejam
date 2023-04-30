using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    private Scene _scene;
    public GameObject _videocanva;
    private IEnumerator coruotine;
    private void Awake()
    {
        _scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void Startbuttonclick()
    {
        StartCoroutine(Waitvideo());
        
    }
    public void Quitgame()
    {
        Application.Quit();
    }
    private IEnumerator Waitvideo()
    {
        _videocanva.SetActive(true);
        
        yield return new WaitForSeconds(30);
        SceneManager.LoadScene(_scene.buildIndex + 1);


    }
}
