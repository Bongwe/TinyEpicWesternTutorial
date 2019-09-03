using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialMenuHandler : MonoBehaviour
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

    public void loadShufflingAndDealingTut()
    {
        buttonClick.Play();
    }

    public void loadPossePlacementTut()
    {
        buttonClick.Play();
        SceneManager.LoadSceneAsync("1.1 - Menu Gameplay");
    }

    public void loadResolutionTut()
    {
        buttonClick.Play();
        SceneManager.LoadSceneAsync("1.1 - Menu Gameplay");
    }

    public void loadBuyTut()
    {
        buttonClick.Play();
        SceneManager.LoadSceneAsync("1.1 - Menu Gameplay");
    }
}
