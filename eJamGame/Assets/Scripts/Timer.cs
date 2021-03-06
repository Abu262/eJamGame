﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 1500f;
    public bool stillTimeLeft = false;
    public Text timeText;
    public Flowchart flowchart;

    // Start is called before the first frame update
    void Start()
    {
        stillTimeLeft = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (stillTimeLeft)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
                /*
                if (timeRemaining < 30)
                {
                    //Trigger some timed event hint
                }*/
            }
            else
            {
                
                timeRemaining = 0;
                stillTimeLeft = false;
                flowchart.ExecuteBlock("Start");
            }
        }
    }

    void DisplayTime(float time)
    {
        time += 1;
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

}
