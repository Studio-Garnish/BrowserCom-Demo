using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;
using TMPro;


public class QuestionManager : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowQuestionWindow();

    [DllImport("__Internal")]
    private static extern void Hello();
    
    public TMP_Text scoreTxt;
    public int points = 0;

    public void ShowQuestion() {
        Debug.Log("Unity: Show question clicked");
        Hello();
        ShowQuestionWindow();
    }

    public void SetQuestionResponse(bool correct) {
        Debug.Log("Question Correct: " + correct);
        if (correct) {
            points += 10;
        } else {
            points -= 3;
        }
        scoreTxt.text = "Score: " + points;
    }

    public void Correct() {
        SetQuestionResponse(true);
    }

    public void Incorrect() {
        SetQuestionResponse(false);
    }
}
