using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGameplayComponents : MonoBehaviour
{
    public GameObject[] gameplayComponents;
    public AudioSource buttonClick;

    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void nextGameplayComponent()
    {
        buttonClick.Play();
        Debug.Log(index);

        if (index < gameplayComponents.Length)
        {
            gameplayComponents[index].SetActive(false);
        }


        if (index < gameplayComponents.Length)
        {
            index++;
            if (index >= gameplayComponents.Length)
            {
                index = 0;
            }
            gameplayComponents[index].SetActive(true);

        }
    }

    /*public void previousGameplayComponent()
    {
        Debug.Log(index);
        buttonClick.Play();

        if (index >= 0 && index < gameplayComponents.Length)
        {
            gameplayComponents[index].SetActive(false);
        }

        int prev = index - 1;
        if (prev >= 0)
        {
            index--;
        }

        if (index >= 0)
        {
            gameplayComponents[index].SetActive(true);
        }
    }*/
}
