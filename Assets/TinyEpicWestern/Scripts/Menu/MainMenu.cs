using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource buttonClick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameplayScene()
    {
        buttonClick.Play();
        SceneManager.LoadSceneAsync("1.1 - Menu Gameplay");
    }

    public void mainManeScene()
    {
        buttonClick.Play();
        SceneManager.LoadSceneAsync("1.0 Menu");
    }

}
