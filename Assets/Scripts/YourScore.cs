using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YourScore : MonoBehaviour
{
    public int score;
    public Text scoreText;
    private void Start()
    {
        score = PlayerPrefs.GetInt("Your score:", score);
        scoreText.text = score.ToString();
    }
}
