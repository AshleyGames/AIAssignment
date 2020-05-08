﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    private Transform entryContainer;
    private Transform entryTemplate;

    private void Awake()
    {
        entryContainer = transform.Find("HighScoreEntryContainer");
        entryTemplate = entryContainer.Find("EntryTemplate");

        entryTemplate.gameObject.SetActive(false);

        float templateHeight = 30f;
        for (int i = 0; i < 10; i++)
        {
            Transform entryTransform = Instantiate(entryTemplate, entryContainer);
            RectTransform entryRectTransform = entryTransform.GetComponent<RectTransform>();
            entryRectTransform.anchoredPosition = new Vector2(0, -templateHeight * i);
            entryTransform.gameObject.SetActive(true);

            int rank = i + 1;
            string rankString;
            switch(rank)
            {
                default:
                    rankString = rank + "TH"; break;

                case 1: rankString = "1st"; break;
                case 2: rankString = "2nd"; break;
                case 3: rankString = "3rd"; break;

            }
            entryTransform.Find("PosText").GetComponent<Text>().text = rankString;

            int score = Random.Range(0, 1000);
            entryTransform.Find("ScoreText").GetComponent<Text>().text = score.ToString();

            string name = "AAA";
            entryTransform.Find("NameText").GetComponent<Text>().text = name;
        }
    }

    private class HighScoreEntry
    {
        public int score;
        public string name;
    }
}