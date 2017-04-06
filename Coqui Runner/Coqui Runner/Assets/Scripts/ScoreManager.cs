using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text hiScoreText;
    public Text coinsText;

    private int coinCount;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;

    public bool shouldDouble;

	// Use this for initialization
	void Start () {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }

        if (PlayerPrefs.HasKey("Coins"))
        {
            coinCount = PlayerPrefs.GetInt("Coins");
        }
    }
	
	// Update is called once per frame
	void Update () {

        if(scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime * 2;
        }

        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount);
        }

        scoreText.text = "SCORE: " + (int) scoreCount;
        hiScoreText.text = "HIGH SCORE: " + (int) hiScoreCount;
        coinsText.text = "COINS: " + coinCount;
    }

    public void AddScore(int pointsToAdd)
    {
        if (shouldDouble)
        {
            pointsToAdd = pointsToAdd * 2;
        }
        scoreCount += pointsToAdd;
    }

    public void AddCoin()
    {
        coinCount += 1;
        PlayerPrefs.SetInt("Coins", coinCount);
    }

}
