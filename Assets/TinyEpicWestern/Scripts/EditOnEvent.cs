using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditOnEvent : MonoBehaviour
{
    public int delayTime = 5;
    private float currentTime = 0;
    private bool updateTime = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (updateTime)
        {
            currentTime = currentTime + Time.deltaTime;
            if (currentTime >= delayTime)
            {
                gameObject.SetActive(false);
                updateTime = false;
            }
        }
    }
}
