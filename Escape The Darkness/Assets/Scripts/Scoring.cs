using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    private float score = 0.0f;

    private int difficultyLevel = 1;
    private int maxDifficultyLevel = 10;
    private int scoreToNextLevel = 10;

    private bool IsDead = false;

    public Text ScoreText;
   
    void Update()
    {
        if (IsDead)
            return;

        if (score >= scoreToNextLevel)
            LevelUp();


        score  += Time.deltaTime * difficultyLevel;
        ScoreText.text = ((int)score).ToString();
    }

    void LevelUp()
    {
        if (difficultyLevel == maxDifficultyLevel)
            return;

        scoreToNextLevel *= 2;
        difficultyLevel++;

        GetComponent<PlayerMovement>().SetSpeed(difficultyLevel);

        Debug.Log (difficultyLevel);
    }

    public void OnDeath()
    {
        IsDead = true;
    }
}
