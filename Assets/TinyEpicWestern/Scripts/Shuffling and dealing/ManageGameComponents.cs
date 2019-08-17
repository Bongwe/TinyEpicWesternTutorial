using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageGameComponents : MonoBehaviour
{
    public GameObject[] gameComponents;

    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void nextInstruction()
    {
        if (index < gameComponents.Length)
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
            }
        }
    }

    public void prevInstruction()
    {
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

}
