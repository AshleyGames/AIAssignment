using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timeSec;

    public Text timerText; 
    //Drag and drop the timer text varaible, in the public script for the gameobject
    

    void Start()
    {
        timeSec = 0;
    }
    //At the start of every game or restart, the time is set to 0

    
    void Update()
    {
        timeSec += Time.deltaTime;
        //Everyframe/second add 1 to the float timeSec
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
    //This gets the numbers from the timsSec Float and turns them into actual time,  minuets and seconds 
}
