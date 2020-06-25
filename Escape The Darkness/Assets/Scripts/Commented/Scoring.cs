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

    //This is saying the first difficuly when games starts up, the maximum it can go to
    //The score it needs to be before leveling up


    public Text ScoreText;
   
    void Update()
    {
        //This is saying depending on the score, will determind when it is leveled up
        if (score >= scoreToNextLevel)
            LevelUp();


        score  += Time.deltaTime * difficultyLevel;
        ScoreText.text = ((int)score).ToString();
    }
    //This is saying when the scoring is leved up, the speed and the mutiplier is also increated
    void LevelUp()
    {
        if (difficultyLevel == maxDifficultyLevel)
            return;

        scoreToNextLevel *= 2;
        difficultyLevel++;

        GetComponent<PlayerMovement>().SetSpeed(difficultyLevel);

        Debug.Log (difficultyLevel);
    }

}
