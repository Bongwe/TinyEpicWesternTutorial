using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageAnimatedObject : MonoBehaviour
{
    public AudioSource soundEffect1;
    public AudioSource soundEffect2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateChildObject()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }

    public void playSoundEffect()
    {
        soundEffect1.Play();
    }

    public void playSoundEffect2()
    {
        soundEffect2.Play();
    }


}
