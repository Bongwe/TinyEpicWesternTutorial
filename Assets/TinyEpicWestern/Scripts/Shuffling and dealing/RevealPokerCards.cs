using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealPokerCards : MonoBehaviour
{
    public GameObject[] pokerCards;
    public AudioSource dealPokerCard;
    public AudioSource removePokerCard;

    private float currentTime = 0;
    private float targetTime = 1;
    private int index = 0;
    private bool revealCards = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime = currentTime + Time.deltaTime;

        if (currentTime >= targetTime && index < pokerCards.Length && revealCards == true)
        {
            pokerCards[index].SetActive(true);
            dealPokerCard.Play();
            currentTime = 0;
            index++;
            if (index >= pokerCards.Length)
            {
                revealCards = false;
                index = 0;
            }
        }

        if (currentTime >= targetTime && index <= pokerCards.Length && revealCards == false)
        {
            pokerCards[index].SetActive(false);
            removePokerCard.Play();
            currentTime = 0;
            index++;
            if (index == pokerCards.Length)
            {
                revealCards = true;
                index = 0;
            }
        }

    }
}
