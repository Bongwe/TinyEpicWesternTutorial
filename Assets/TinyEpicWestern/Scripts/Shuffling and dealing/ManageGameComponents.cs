﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGameComponents : MonoBehaviour
{
   private int revealCardAtIndex = 5; 

    public GameObject gameComponentKeepVisible;
    public GameObject[] gameComponents;
    public AudioSource clickSound;

    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(index >= revealCardAtIndex && gameComponentKeepVisible != null)
        {
            gameComponentKeepVisible.SetActive(true);
        } else if (index <= revealCardAtIndex && gameComponentKeepVisible != null)
        {
            gameComponentKeepVisible.SetActive(false);
        }
    }

   public void nextInstruction()
    {
        clickSound.Play();
        if (index < (gameComponents.Length - 1))
        {
            index++;
            int nextIndex = index - 1;
            if (nextIndex >= 0)
            {
                gameComponents[nextIndex].SetActive(false);
            }
            if (index < gameComponents.Length)
            {
                gameComponents[index].SetActive(true);
                if (gameComponents[index].tag == "anInstruction")
                {
                    gameComponents[index].GetComponent<AudioSource>().Play();
                }
            }
        }
    }

    public void prevInstruction()
    {
        clickSound.Play();
        if (index > 0)
        {
            index--;
            int prevIndex = index + 1;
            if (prevIndex < gameComponents.Length)
            {
                gameComponents[prevIndex].SetActive(false);
            }
            Debug.Log(index);
            if (index >= 0)
            {
                gameComponents[index].SetActive(true);
            }
        }
    }

    public void quitAppliaction()
    {
        Application.Quit();
    }
    public void showCurrentInstruction()
    {
        clickSound.Play();
        if (gameComponents[index].tag == "anInstruction")
        {
            gameComponents[index].GetComponent<ManageMessage>().displayInstrction();
            gameComponents[index].GetComponent<AudioSource>().Play();

        }
        else
        {
            int prevIndex = index - 1;
            if (prevIndex >= 0)
            {
                gameComponents[prevIndex].GetComponent<ManageMessage>().displayInstrction();
                gameComponents[prevIndex].GetComponent<AudioSource>().Play();
            }
        }
    }

}
