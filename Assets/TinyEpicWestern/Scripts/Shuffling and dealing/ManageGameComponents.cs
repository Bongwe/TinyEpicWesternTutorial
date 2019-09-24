using System.Collections;
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
                if (gameComponents[nextIndex].tag == "aCombo")
                {
                    gameComponents[nextIndex].GetComponent<RevealInstructionandCompo>().setActive(false);

                }
            }
            if (index < gameComponents.Length)
            {
                gameComponents[index].SetActive(true);
                if (gameComponents[index].tag == "anInstruction")
                {
                    AudioSource audioSource = gameComponents[index].GetComponent<AudioSource>();
                    if(audioSource != null)
                    {
                        audioSource.Play();
                    }
                }
                if (gameComponents[index].tag == "aCombo")
                {
                    gameComponents[index].GetComponent<RevealInstructionandCompo>().setActive(true);
                    gameComponents[index].GetComponent<RevealInstructionandCompo>().displayInstrction();
                    gameComponents[index].GetComponent<RevealInstructionandCompo>().playAudio();

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
                if (gameComponents[prevIndex].tag == "aCombo")
                {
                    gameComponents[prevIndex].GetComponent<RevealInstructionandCompo>().setActive(false);

                }
            }
            Debug.Log(index);
            if (index >= 0)
            {
                gameComponents[index].SetActive(true);
                if (gameComponents[index].tag == "anInstruction")
                {
                    gameComponents[index].GetComponent<AudioSource>().Play();
                }
                if (gameComponents[index].tag == "aCombo")
                {
                    gameComponents[index].GetComponent<RevealInstructionandCompo>().setActive(true);
                    gameComponents[index].GetComponent<RevealInstructionandCompo>().displayInstrction();
                    gameComponents[index].GetComponent<RevealInstructionandCompo>().playAudio();

                }
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
            AudioSource audioSource = gameComponents[index].GetComponent<AudioSource>();
            if(audioSource != null)
            {
                audioSource.Play();
            }

        }
        else if (gameComponents[index].tag == "aCombo")
        {
            gameComponents[index].GetComponent<RevealInstructionandCompo>().displayInstrction();
            gameComponents[index].GetComponent<RevealInstructionandCompo>().playAudio();

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
