using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LerionQuizManager : MonoBehaviour
{
    [Header("Lerion Quiz Elements")]
    public Text questionDescription;
    public Text numberQuestion;
    
    public Button aButton, bButton, cButton, dButton;

    [Header("Score")]
    public Text scoreText, outputText;
    public GameObject resultPanel;
    private int score = 0; // Tracks the current score
    private int totalQuestions = 30; // Total number of questions for the quiz

    [System.Serializable]
    public struct LerionQuizQuestion
    {
        public string question;
        public string[] choices;
        public string correctAnswer;
    }

    public List<LerionQuizQuestion> quizQuestions = new List<LerionQuizQuestion>();
    private int currentQuestionIndex = 0;
    private List<int> questionOrder = new List<int>(); // Randomized question indices

    private void Start()
    {
        ShuffleQuestions();
        UpdateScoreText();
        DisplayQuestion();
    }

    private void ShuffleQuestions()
    {
        for (int i = 0; i < quizQuestions.Count; i++)
        {
            questionOrder.Add(i);
        }

        for (int i = 0; i < questionOrder.Count; i++)
        {
            int randomIndex = Random.Range(i, questionOrder.Count);
            int temp = questionOrder[i];
            questionOrder[i] = questionOrder[randomIndex];
            questionOrder[randomIndex] = temp;
        }
    }

    private void DisplayQuestion()
    {
        if (quizQuestions.Count == 0 || currentQuestionIndex >= quizQuestions.Count) return;

        var question = quizQuestions[questionOrder[currentQuestionIndex]];
        questionDescription.text = question.question;
        numberQuestion.text = $"{currentQuestionIndex + 1}."; // Display current question number

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
            if (currentQuestionIndex < 0 || currentQuestionIndex >= questionOrder.Count)
            {
                Debug.LogError("Current question index is out of range.");
                return;
            }

            var correctAnswer = quizQuestions[questionOrder[currentQuestionIndex]].correctAnswer;

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

            if (currentQuestionIndex < questionOrder.Count)
            {
                DisplayQuestion();
            }
            else
            {
                Debug.Log("Quiz Finished!");
                resultPanel.SetActive(true);  // Show result panel
            }
        }

    private void UpdateScoreText()
    {
        scoreText.text = $"{score} /30"; // Display the score
        outputText.text = $"{score} /30"; // panel score
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
