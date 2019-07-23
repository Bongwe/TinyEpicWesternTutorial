using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealObject : MonoBehaviour
{
    public GameObject[] anObject;
    public float timeLeft = 0;
    public bool startCounting = true;
    public int delayTime = 2;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft = timeLeft + Time.deltaTime;
        if (timeLeft >= delayTime)
        {
            anObject[0].SetActive(true);
        }
        if (timeLeft >= delayTime + 2)
        {
            anObject[1].SetActive(true);
        }
        if (timeLeft >= delayTime + 4)
        {
            anObject[2].SetActive(true);
        }
        if (timeLeft >= delayTime + 6)
        {
            anObject[3].SetActive(true);
        }
        if (timeLeft >= delayTime + 8)
        {
            anObject[4].SetActive(true);
        }
    }
}
