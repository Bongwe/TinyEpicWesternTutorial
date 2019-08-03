using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageTutorial : MonoBehaviour
{
    public GameObject[] gameLessons;
    public GameObject[] gameInstructions;
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
        if (index < gameLessons.Length)
        {
            //int prevObjectIndex = index - 1;
            //if (prevObjectIndex > -1)
            //{
            //    GameObject child = gameLessons[prevObjectIndex].transform.GetChild(0).gameObject;
            //    child.SetActive(false);
            //}
            //GameObject child = gameLessons[index].transform.GetChild(0).gameObject;
            //child.SetActive(false);
            gameLessons[index].SetActive(true);
            index++;
            showCurrentInstruction();
        }
    }

    public void showCurrentInstruction()
    {
        gameInstructions[index].GetComponent<ManageMessage>().displayInstrction();
    }


}
