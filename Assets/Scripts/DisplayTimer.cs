using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayTimer : MonoBehaviour
{
    public TextMeshProUGUI textTimer;

    private float timer = 21595.0f;
    private bool isTimer = true;

    // Update is called once per frame
    void Update()
    {
        if (isTimer)
        {
            timer += Time.deltaTime;
            DisplayTime();
        }
    }

    void DisplayTime()
    {
        
        int minutes = Mathf.FloorToInt(((timer / 60.0f)% 60.0f));
        //int seconds = Mathf.FloorToInt(timer - minutes * 60);
        int hours = Mathf.FloorToInt(((timer / 60.0f) / 60.0f));
        textTimer.text = string.Format("{0:00}:{1:00}", hours, minutes);
    }

    public void StartTimer()
    {

        isTimer = true;
    }

    public void StopTimer()
    {
        isTimer = false;
    }

    public void ResetTimer()
    {
        timer = 0.0f;
    }
 }


