using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public TMP_Text textbox;
    public string[] sentences;
    private int index;
    public float typingSpeed;
    public GameObject continueButton;
    public GameObject dialogPanel; 
    IEnumerator Type()
    {
        textbox.text = "";
        foreach (char letter in sentences[index])
        {
            textbox.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        continueButton.SetActive(true);
    }

    void OnEnable()
    {
        continueButton.SetActive(false);
        StartCoroutine(Type());
    }

    public void NextSentence()
    {
        continueButton.SetActive(false);
        if (index < sentences.Length -1)
        {
            index++;
            textbox.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textbox.text = "";
            dialogPanel.SetActive(false);
        }
    }
}
