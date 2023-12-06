using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreAmountText;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        LoadScore();
    }

    public void OnUpdateScoreButtonPressed()
    {
        score += 10;
        scoreAmountText.text = score.ToString();
        SaveScore();
    }
    public void SaveScore()
    {
        PlayerPrefs.SetInt("Score",score);
    }

    public void LoadScore() {
        score = PlayerPrefs.GetInt("Score", 0);
        scoreAmountText.text = score.ToString();
    }
}
