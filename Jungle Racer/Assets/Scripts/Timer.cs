using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    [Header("Component")]
    public TextMeshProUGUI timerText;


    [Header("TimerSettings")]
    public float currentTime;
    void Start()



    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        timerText.text = currentTime.ToString();
        SetTimerText();



        //enabled = false;

    }

    private void SetTimerText()
    {
        timerText.text = currentTime.ToString("0.00");
    }

}
