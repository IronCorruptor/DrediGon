using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuController : MonoBehaviour
{
    public string MainGame;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGame()
    {
        SceneManager.LoadScene(MainGame);


    }

    public void OptionsOpen()
    {



    }

    public void OptionsClose()
    {



    }

    public void QuitGame()
    {
        Application.Quit();
    }
}