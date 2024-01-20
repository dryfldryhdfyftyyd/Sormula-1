using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RacerScript : MonoBehaviour
{
    public float laptime = 0;
    public float besttime = 0;
    private bool startTimer = false;
    private bool checkpoint1 = false;
    private bool checkpoint2 = false;

    public UnityEngine.UI.Text LTime;
    public UnityEngine.UI.Text BTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer == true)
        { 
            laptime += Time.deltaTime;
            LTime.text = "LAP TIME: " + laptime.ToString("F2");
        }
        
    }
    void OnTriggerEnter(Collider other)
    {




        
        if (other.gameObject.name == "Start")
        {
            if (startTimer == false)
            {
                startTimer = true;
                laptime = 0;
                checkpoint1 = false;
                checkpoint2 = false;
            }

            
        }
        if (other.gameObject.name == "Finish")
        { 
           if (checkpoint1 == true && checkpoint2 == true)
            {
                startTimer = false;
                if (besttime == 0)
                {
                    besttime = laptime;
                }
                if (laptime < besttime)
                {
                    besttime = laptime;
                }
                BTime.text = "Best TIME: " + besttime.ToString("F2");

            } 
        }

        if (other.gameObject.tag == "Check1")
        {
            Debug.Log("Check1");
            checkpoint1 = true;
        }
        if (other.gameObject.tag == "Check2")
        {
            Debug.Log("Check2");
            checkpoint2 = true;
        }
        
    }
}
