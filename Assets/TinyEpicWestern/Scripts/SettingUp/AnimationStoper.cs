using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStoper : MonoBehaviour
{
    public AudioSource dealMat;
    public AudioSource takeAwayMat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playDealMatSound()
    {
        dealMat.Play();
    }

    public void playTakeMatSound()
    {
        takeAwayMat.Play();
    }

}
