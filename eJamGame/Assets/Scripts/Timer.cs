using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 70f;
    public bool stillTimeLeft = false;
    public Text timeText;

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

                if (timeRemaining < 30)
                {
                    //Trigger some timed event hint
                }
            }
            else
            {
                Debug.Log("No more time");
                timeRemaining = 0;
                stillTimeLeft = false;
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
