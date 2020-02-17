using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CollectResponse : MonoBehaviour
{
    public char Response;
    public string ConfidentAnswer;
    public InputField InputField;
    public Button SubmitButton;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SubmitButton.onClick.Invoke();
        }
    }
    public void StoreResponse()              //Storing User Response As A Character
    {
        if (InputField.text.Length == 1)
        {
            Response = Convert.ToChar(InputField.text.ToUpper());
        }
        else if (InputField.text.Length > 1)
        {
            ConfidentAnswer = InputField.text.ToUpper();
        }
        print(Response);
    }
    public void ClearInputField()
    {
        InputField.text = "";
    }
}
