using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageAnimation : MonoBehaviour
{
    // Start is called before the first frame update

    void Awake()
    {
        Animator animator = gameObject.GetComponent<Animator>();
        animator.enabled = false;
    }

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
