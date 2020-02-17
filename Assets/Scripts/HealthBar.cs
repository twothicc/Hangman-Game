using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public GameObject[] Hearts = new GameObject[10];
    public GameObject Hangman;
    void Update()
    {
        for (int i = 0; i < Hangman.GetComponent<HangmanDisplayer>().GetHangman; i++)
        {
            Hearts[i].GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
