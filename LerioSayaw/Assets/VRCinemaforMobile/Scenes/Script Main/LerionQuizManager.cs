using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LerionQuizManager : MonoBehaviour
{
    [Header("Lerion Quiz Elements")]
    public Text questionDescription;
    public Button aButton, bButton, cButton, dButton;

    [Header("Score")]
    public Text scoreText, outputText;
    public GameObject resultPanel;
    private int score = 0; // Tracks the current score
    private int totalQuestions = 30; // Total number of questions for the quiz

    // Struct to store a question and its options
    [System.Serializable]
    public struct LerionQuizQuestion
    {
        public string question;
        public string[] choices;
        public string correctAnswer;
    }

    public List<LerionQuizQuestion> quizQuestions = new List<LerionQuizQuestion>();
    private int currentQuestionIndex = 0;

    private void Start()
    {
        UpdateScoreText();
        DisplayQuestion();
    }

    private void DisplayQuestion()
    {
        if (quizQuestions.Count == 0 || currentQuestionIndex >= quizQuestions.Count) return;

        var question = quizQuestions[currentQuestionIndex];
        questionDescription.text = question.question;

        if (question.choices.Length != 4)
        {
            Debug.LogError("Each question must have exactly 4 choices.");
            return;
        }

        aButton.GetComponentInChildren<Text>().text = question.choices[0];
        bButton.GetComponentInChildren<Text>().text = question.choices[1];
        cButton.GetComponentInChildren<Text>().text = question.choices[2];
        dButton.GetComponentInChildren<Text>().text = question.choices[3];

        aButton.onClick.RemoveAllListeners();
        bButton.onClick.RemoveAllListeners();
        cButton.onClick.RemoveAllListeners();
        dButton.onClick.RemoveAllListeners();

        aButton.onClick.AddListener(() => CheckAnswer(question.choices[0]));
        bButton.onClick.AddListener(() => CheckAnswer(question.choices[1]));
        cButton.onClick.AddListener(() => CheckAnswer(question.choices[2]));
        dButton.onClick.AddListener(() => CheckAnswer(question.choices[3]));
    }

    private void CheckAnswer(string selectedAnswer)
    {
        if (currentQuestionIndex < 0 || currentQuestionIndex >= quizQuestions.Count)
        {
            resultPanel.SetActive(true);
            Debug.Log("Current question index is out of range.");
            return;
        }

        var correctAnswer = quizQuestions[currentQuestionIndex].correctAnswer;

        if (selectedAnswer == correctAnswer)
        {
            Debug.Log("Correct Answer!");
            score++; // Increment the score for a correct answer
        }
        else
        {
            Debug.Log("Wrong Answer!");
        }

        UpdateScoreText(); // Update the score display

        // Move to the next question
        currentQuestionIndex++;
        if (currentQuestionIndex < quizQuestions.Count)
        {
            DisplayQuestion();
        }
        else
        {
            Debug.Log("Quiz Finished!");
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = score.ToString() + " /30"; // Display the score
        outputText.text = score.ToString() + " /30"; // panel score
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitSystem()
    {
        Application.Quit();
    }
}
