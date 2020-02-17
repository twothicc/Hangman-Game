using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using UnityEngine.SceneManagement;
public class AnswerChecker : MonoBehaviour
{
    public GameObject AnswerDisplayer;
    public GameObject CollectResponse;
    public GameObject BringsWordGeneratorDataToNextScene;
    public GameObject Hangman;
    public ParticleSystem ConeConfetti1;
    public ParticleSystem ConeConfetti2;
    public AudioSource CelebrationSounds;
    public AudioSource WrongSound;
    public Text TEXT;
    bool A = false;
    public void CheckAnswer()
    {
        print("checking");
        BringsWordGeneratorDataToNextScene = GameObject.Find("BringsWordGeneratorDataToNextScene");
        A = false;
        for (int i = 0; i < AnswerDisplayer.GetComponent<DisplayAnswer>().n; i++)
        {
            print("debug");
            print(BringsWordGeneratorDataToNextScene.GetComponent<WordGenerator>().GetAnswer.ToCharArray()[i]);
            print(CollectResponse.GetComponent<CollectResponse>().Response);
            if (BringsWordGeneratorDataToNextScene.GetComponent<WordGenerator>().GetAnswer.ToCharArray()[i] == CollectResponse.GetComponent<CollectResponse>().Response)
            {
                char[] array = TEXT.text.ToCharArray();
                array[i] = CollectResponse.GetComponent<CollectResponse>().Response;
                string str = new string(array);
                TEXT.text = str;
                ConeConfetti1.Play();
                ConeConfetti2.Play();
                CelebrationSounds.Play();
                A = true;
                print(TEXT.text);
                print("AnswerUpdated");
                print(A);
            }
        }
        if (CollectResponse.GetComponent<CollectResponse>().ConfidentAnswer.Length > 4)
        {
            if(CollectResponse.GetComponent<CollectResponse>().ConfidentAnswer== BringsWordGeneratorDataToNextScene.GetComponent<WordGenerator>().GetAnswer)
            {
                TEXT.text = CollectResponse.GetComponent<CollectResponse>().ConfidentAnswer;
                ConeConfetti1.Play();
                ConeConfetti2.Play();
                CelebrationSounds.Play();
                A = true;
            }
        }
        if (A == false)
        {
            Hangman.GetComponent<HangmanDisplayer>().GetHangman += 1;
            print(Hangman.GetComponent<HangmanDisplayer>().GetHangman);
            WrongSound.Play();
        }
    }
    void Update()
    {
        BringsWordGeneratorDataToNextScene = GameObject.Find("BringsWordGeneratorDataToNextScene");
        if (TEXT.text== BringsWordGeneratorDataToNextScene.GetComponent<WordGenerator>().GetAnswer)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
