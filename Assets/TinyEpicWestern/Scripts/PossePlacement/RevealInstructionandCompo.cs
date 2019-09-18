using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealInstructionandCompo : MonoBehaviour
{
    public GameObject instruction;
    public GameObject gameComponent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void displayInstrction()
    {
        instruction.GetComponent<ManageMessage>().displayInstrction();

    }

    public void playAudio()
    {
        instruction.GetComponent<AudioSource>().Play();

    }

    public void setActive(bool value)
    {
        instruction.SetActive(value);
        gameComponent.SetActive(value);

    }
    
}
