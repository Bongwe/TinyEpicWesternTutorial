using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadingHandler : MonoBehaviour
{
    public GameObject description;
    public AudioSource buttonClick;

    private bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showDescription()
    {
        buttonClick.Play();
        isActive = !isActive;
        Debug.Log(isActive);
        description.SetActive(isActive);
    }
}
