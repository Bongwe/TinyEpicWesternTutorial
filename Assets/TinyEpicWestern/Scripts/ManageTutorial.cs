using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageTutorial : MonoBehaviour
{
    public GameObject[] gameLessons;
    public GameObject[] gameInstructions;
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

    public void showNextLesson()
    {
        buttonClick.Play();
        if (index < gameLessons.Length)
        {
            diableAnimation(index - 1);
            enableAnimation(index);
           
            gameLessons[index].SetActive(true);
            index++;
            showCurrentInstruction();
        }
    }

    public void showCurrentInstruction()
    {
        buttonClick.Play();
        gameInstructions[index].GetComponent<ManageMessage>().displayInstrction();
    }

    private void enableAnimation(int index)
    {
        GameObject hand = GameObject.Find(gameLessons[index].name + "Borders");
        for (int count = 0; count < hand.transform.childCount; count++)
        {
            Animator animator = hand.transform.GetChild(count).GetComponent<Animator>();
            animator.enabled = true;
        }
    }

    private void diableAnimation(int index)
    {
        if(index >= 0)
        {
            GameObject hand = GameObject.Find(gameLessons[index].name + "Borders");
            for (int count = 0; count < hand.transform.childCount; count++)
            {
                Animator animator = hand.transform.GetChild(count).GetComponent<Animator>();
                animator.SetBool("StopFlash", true);
            }
        }
        
    }


}
