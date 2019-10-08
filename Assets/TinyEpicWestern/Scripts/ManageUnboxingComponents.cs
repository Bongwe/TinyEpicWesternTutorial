using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageUnboxingComponents : MonoBehaviour
{
    public GameObject gameBox;
    public GameObject gameBoxAnimated;
    public GameObject innerGameBox;
    public GameObject componentsAndDescriptions;
    public GameObject[] animatedGameComponents;
    public GameObject competeMessage;

    public AudioSource buttonClick;
    public AudioSource unboxingSound;

    private bool isBoxOpen = false;
    private float currentTime = 0;
    private float delayTime = 3;
    private int componentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isBoxOpen == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
    }

    public void playAnimation()
    {
        buttonClick.Play();
        if (isBoxOpen == false)
        {
            unboxingSound.Play();
            gameBox.SetActive(false);
            gameBoxAnimated.SetActive(true);
            displayInnerBox();
            isBoxOpen = true;
        } else if (isBoxOpen == true && currentTime > delayTime && componentIndex < animatedGameComponents.Length) {
            animatedGameComponents[componentIndex].SetActive(true);
            componentIndex++;
            currentTime = 0;
        }
        /*if (componentIndex > animatedGameComponents.Length)
        {
            competeMessage.SetActive(true);
        }*/

    }

    public void displayInnerBox()
    {
        innerGameBox.SetActive(true);
    }
}
