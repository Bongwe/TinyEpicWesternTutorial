using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NavigationScript : MonoBehaviour
{
    public List<Image> images = null;
    public string nextSceneName;
    public string prevSceneName;

    private int currentInfo;

    // Start is called before the first frame update
    void Start()
    {
        currentInfo = 0;
        for (int index = 1; index < images.Count; index++)
        {
            images[index].enabled = false;  
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextInstruction()
    {
        if (currentInfo < images.Count) {
            if ((currentInfo + 1) < images.Count)
            {
                images[currentInfo].enabled = false;
                images[currentInfo + 1].enabled = true;
                currentInfo++;
            }
        }

        if ((currentInfo +1) >= images.Count)
        {
            nextScene();
        }
        Debug.Log(currentInfo);
        
    }

    public void prevInstruction()
    {
        if (currentInfo > -1)
        {
            if ((currentInfo - 1) > -1)
            {
                images[currentInfo].enabled = false;
                images[currentInfo-1].enabled = true;
                currentInfo--;
            }
        }
        Debug.Log(currentInfo);


    }


    public void nextScene()
    {
        LoadScene(nextSceneName);
    }

    public void prevScene()
    {
        LoadScene(prevSceneName);
    }

    void LoadScene(string sceneName)
    {
        Debug.Log("LoadScene(" + sceneName + ") called.");
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    public void quitAppliaction()
    {
        Application.Quit();
    }

}
