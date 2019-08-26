using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleBottomBarHint : MonoBehaviour
{
    public GameObject hint;
    public GameObject defaultHint;

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
        hint.SetActive(true);
        defaultHint.SetActive(false);
    }

    void OnDisable()
    {
        hint.SetActive(false);
        defaultHint.SetActive(true);
    }
}
