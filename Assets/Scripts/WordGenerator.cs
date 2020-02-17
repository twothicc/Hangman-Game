using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random = System.Random;

public class WordGenerator : MonoBehaviour
{
    private string Answer;             //For Universal Reference + Cannot be edited once chosen
    public string GetAnswer
    {
        get { return Answer; }
    }
    private int WordListNumber;        //For Universal Reference
    public int CategoryOfWord
    {
        get { return WordListNumber; }
    }
    public string[][] jaggedArray = new string[][]
    {
        new string[]{"ELEPHANT","TIGER","GIRAFFE","RHINOCEROS","ALLIGATOR","DOLPHIN","LEOPARD","KANGAROO"},
        new string[]{ "AUSTRALIA", "SOMALIA", "MADAGASCAR", "HUNGARY", "LUXEMBOURG","VENEZUELA","MOZAMBIQUE","URUGUAY" }
    };

    public int RandomNumber(int min, int max)       //Random Number Generator Function
    {
        Random random = new Random();
        return random.Next(min, max);
    }
    public void GenerateWord()
    {
        WordListNumber = RandomNumber(0, 2);
        Answer = jaggedArray[WordListNumber][RandomNumber(0, 8)];
        print(Answer);
    }

}
