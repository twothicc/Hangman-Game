using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
    public GameObject BringsWordGeneratorDataToNextScene;
    public Text HINT;
    void Start()
    {
        BringsWordGeneratorDataToNextScene = GameObject.Find("BringsWordGeneratorDataToNextScene");
        if(BringsWordGeneratorDataToNextScene.GetComponent<WordGenerator>().CategoryOfWord==0)
        {
            HINT.text = "Guess An Animal";
        }
        else if(BringsWordGeneratorDataToNextScene.GetComponent<WordGenerator>().CategoryOfWord==1)
        {
            HINT.text = "Guess A Country";
        }
    }
}
