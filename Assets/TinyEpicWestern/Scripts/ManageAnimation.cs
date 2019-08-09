using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animator animator = gameObject.GetComponent<Animator>();
        animator.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
