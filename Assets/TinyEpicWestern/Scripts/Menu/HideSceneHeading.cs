using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideSceneHeading : MonoBehaviour
{
    private float currentTime = 0;
    private float delayTime = 5;
    private bool isCount = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCount == true)
        {
            currentTime = currentTime + Time.deltaTime;
           
        }
        if (currentTime>= delayTime)
        {
            isCount = false;
            gameObject.SetActive(false);
        }
    }
}
