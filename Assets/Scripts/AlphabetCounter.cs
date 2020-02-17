using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;
using UnityEngine.UI;

public class AlphabetCounter : MonoBehaviour
{
    string AlphabetList = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public Text Alphabet;
    public GameObject ResponseCollect;
    string Reference;
    char[] Alphabets2;
    void Start()
    {
        char[] Alphabets = AlphabetList.ToCharArray();
        for (int i=0;i<26;i++)
        {
            Alphabets[i] = Convert.ToChar("_");
        }
        StringBuilder AlphabetBuilder = new StringBuilder();
        foreach (char value in Alphabets)
        {
            AlphabetBuilder.Append(value).Append(" ");
        }
        string result = AlphabetBuilder.ToString();
        Alphabets2 = result.ToCharArray();
        Alphabet.text = result;
    }
    void Update()
    {
        for (int i=0;i<26;i++)
        {
            if (AlphabetList[i] == ResponseCollect.GetComponent<CollectResponse>().Response)
            {
                Alphabets2[i * 2] = ResponseCollect.GetComponent<CollectResponse>().Response;
                StringBuilder AlphabetBuilder2 = new StringBuilder();
                foreach (char value in Alphabets2)
                {
                    AlphabetBuilder2.Append(value);
                }
                string result = AlphabetBuilder2.ToString();
                Alphabet.text = result;
            }
        }
    }
}
