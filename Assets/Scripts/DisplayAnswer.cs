using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text;

public class DisplayAnswer : MonoBehaviour
{
    public int n;
    public Text txt;
    public GameObject BringsWordGeneratorDataToNextScene;

    void Start()
    {
        GameObject BringsWordGeneratorDataToNextScene = GameObject.Find("BringsWordGeneratorDataToNextScene");
        char[] NumberOfBlanks = new char[BringsWordGeneratorDataToNextScene.GetComponent<WordGenerator>().GetAnswer.ToCharArray().Length];
        n = NumberOfBlanks.Length;
        print(n);
        for (int i = 0; i < n; i++)
        {
            NumberOfBlanks[i] = Convert.ToChar("?");
        }
        print("displayedanswer");
        StringBuilder StringBuilder = new StringBuilder();
        foreach(char value in NumberOfBlanks)
        {
            StringBuilder.Append(value);
        }
        string result = StringBuilder.ToString();
        txt.text = result;
    }
 
}
