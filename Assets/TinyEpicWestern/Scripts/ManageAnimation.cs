using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageAnimation : MonoBehaviour
{
    // Start is called before the first frame update

    void Awake()
    {
        Animator animator = gameObject.GetComponent<Animator>();
        animator.enabled = true;
        Invoke("stopAnimation", 8);//this will happen after 2 seconds
    }

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAnimation()
    {
        Animator animator = gameObject.GetComponent<Animator>();
        animator.enabled = true;
        Invoke("stopAnimation", 8);//this will happen after 2 seconds
    }

    public void stopAnimation()
    {
        Animator animator = gameObject.GetComponent<Animator>();
        animator.enabled = false;
    }
}
