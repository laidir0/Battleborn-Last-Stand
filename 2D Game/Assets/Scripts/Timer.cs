using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{

    [SerializeField] float timeValue = 90;
    public TextMeshProUGUI timeText;
    

    // Update is called once per frame
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime; // decreases the time steadily
        }
        else
        {
            // condition here, probably change to win scene
        }

        DisplayTime(timeValue);
    }
    void DisplayTime(float timeToDisplay)
    {
        if(timeToDisplay < 0)
        {
            timeToDisplay = 0; // if the time has reached zero, it will properly display on the text box
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); // rounds the current time to the nearest whole number
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); // checks to see how many full minutes are in the time value, takes them away, then returns what's left
                                                              // e.g. timetoDisplay == 90 seconds (90 % 60) = 30

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // quotes tells how to display the minutes and seconds values
    }
}
