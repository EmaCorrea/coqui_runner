using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerupManager : MonoBehaviour {

    private bool doublePoints;
    private bool powerupActive;

    private float powerupLengthCounter;

    private ScoreManager theScoreManager;

    private float normalPointsPerSecond;

    public Text scoreText;

    // Use this for initialization
    void Start () {
        theScoreManager = FindObjectOfType<ScoreManager>();
        normalPointsPerSecond = theScoreManager.pointsPerSecond;
    }
	
	// Update is called once per frame
	void Update () {
		if(powerupActive)
        {
            scoreText.color = Color.red;
            scoreText.fontSize = 17;
            //PlayerPrefs.DeleteAll();
            powerupLengthCounter -= Time.deltaTime;

            if (doublePoints)
            {
                theScoreManager.pointsPerSecond = 5.0f;
                theScoreManager.shouldDouble = true;
            }

            if(powerupLengthCounter <= 0)
            {
                scoreText.color = Color.black;
                scoreText.fontSize = 15;
                theScoreManager.pointsPerSecond = normalPointsPerSecond;
                theScoreManager.shouldDouble = false;
                powerupActive = false;
            }
        }
	}

    public void ActivatePowerup(bool points, float time)
    {
        doublePoints = points;
        powerupLengthCounter = time;  
        powerupActive = true;
    }

    public void StopPowerup()
    {
        powerupLengthCounter = 0f;
    }

}
