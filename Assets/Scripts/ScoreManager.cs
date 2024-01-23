using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager instance;

    public static ScoreManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<ScoreManager>();
            }
            return instance;
        }
    }

    private int score = 0;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        if (scoreText == null)
        {
            Debug.LogError("El objeto de texto no está asignado en el inspector.");
        }
    }

    public void UpdateScore(int value)
    {
        score += value;
        if (scoreText != null)
        {
            scoreText.text = "Puntos: " + score;
        }
    }

    public int GetScore()
    {
        return score;
    }
}
