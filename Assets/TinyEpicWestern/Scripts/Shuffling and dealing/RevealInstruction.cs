using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealInstruction : MonoBehaviour
{
    public GameObject instructionInCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable()
    {
        instructionInCanvas.SetActive(true);
    }

    void OnDisable()
    {
        instructionInCanvas.SetActive(false);
    }
}
