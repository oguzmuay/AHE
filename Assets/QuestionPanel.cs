using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionPanel : MonoBehaviour
{
    private Question _question;
    class Question
    {
        public String question;
        public String answerA, answerB, answerC, answerD;
        public int correctAnswer;

        public Question(String question, String answerA, String answerB, String answerC, String answerD, int correctAnswer)
        {
            this.question = question;
            this.answerA = answerA;
            this.answerB = answerB;
            this.answerC = answerC;
            this.answerD = answerD;
            this.correctAnswer = correctAnswer;
        }
    }

    public void CheckAnswer(int answer)
    {
        if (answer == _question.correctAnswer)
        {
            _question = null;
            gameObject.SetActive(false);
        }
    }
}
