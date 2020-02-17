using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HangmanDisplayer : MonoBehaviour
{
    private static int Hangman = 0;
    public GameObject[] HangmanParts = new GameObject[10];
    public int GetHangman
    {
        get { return Hangman; }
        set { Hangman = value; }
    }
    void Update()
    {
        for (int i = 0; i < Hangman; i++)
        {
            HangmanParts[i].GetComponent<MeshRenderer>().enabled = true;
        }
        if (Hangman == 10)
        {
            SceneManager.LoadScene("lose");
        }
    }
}
