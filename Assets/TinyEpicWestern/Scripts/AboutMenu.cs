using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AboutMenu : MonoBehaviour
{
    public List<Image> images = null;
    private int currentInfo;

    // Start is called before the first frame update
    void Start()
    {
        currentInfo = 0;
        for (int index = 1; index < images.Count; index++)
        {
            images[index].enabled = false;  
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextAboutInfo()
    {
        if (currentInfo < images.Count) {
            if ((currentInfo + 1) < images.Count)
            {
                images[currentInfo].enabled = false;
                images[currentInfo + 1].enabled = true;
                currentInfo++;
            }
        }
        Debug.Log(currentInfo);
        
    }

    public void prevAboutInfo()
    {
        if (currentInfo > -1)
        {
            if ((currentInfo - 1) > -1)
            {
                images[currentInfo].enabled = false;
                images[currentInfo-1].enabled = true;
                currentInfo--;
            }
        }
        Debug.Log(currentInfo);


    }
}
