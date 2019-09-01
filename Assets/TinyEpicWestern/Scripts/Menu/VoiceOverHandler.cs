using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOverHandler : MonoBehaviour
{

    public AudioSource voiceOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playVoiceOver()
    {
        voiceOver.Play();
    }
}
