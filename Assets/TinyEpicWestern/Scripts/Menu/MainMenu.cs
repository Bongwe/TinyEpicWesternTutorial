using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource buttonClick;

    public string nextSceneName = "";
    public string prevSceneName = "";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mainMenuScene()
    {
        buttonClick.Play();
        SceneManager.LoadSceneAsync("1-MainMenu");
    }

    public void gameplayScene()
    {
        buttonClick.Play();
        SceneManager.LoadSceneAsync("2-Gameplay");
    }

    public void tutorialScene()
    {
        buttonClick.Play();
        SceneManager.LoadSceneAsync("4-Unboxing");
    }

        public void creditsScene()
    {
        buttonClick.Play();
        SceneManager.LoadSceneAsync("3.1 Credits");
    }

    public void nextScene()
    {
        buttonClick.Play();
        if (nextSceneName != "")
        {
            SceneManager.LoadSceneAsync(nextSceneName);
        }
    }

    public void prevScene()
    {
        buttonClick.Play();
        if (prevSceneName != "")
        {
            SceneManager.LoadSceneAsync(prevSceneName);
        }
    }

    public void quitAppliaction()
    {
        buttonClick.Play();
        Application.Quit();
    }

}
