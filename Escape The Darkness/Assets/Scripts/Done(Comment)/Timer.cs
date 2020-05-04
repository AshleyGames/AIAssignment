using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timeSec;

    public Text timerText; 
    // Start is called before the first frame update
    void Start()
    {
        timeSec = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeSec += Time.deltaTime;
        timerText.text = getTime();
    }

    public string getTime()
    {
        float minutes = Mathf.Floor(timeSec / 60);
        float seconds = timeSec % 60;

        string sec = seconds.ToString("00");
        string min = minutes.ToString("00");
        return min + ":" + sec;
    }
}
