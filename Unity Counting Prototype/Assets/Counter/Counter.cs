using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;
    int smallCount;
    int mediumCount;
    int largeCount;

    private int count = 0;

    private void Start()
    {
       
        count = 0;
    }

    private void Update()
    {
        smallCount = GameObject.Find("SmallCageCounter").GetComponent<CounterSmall>().count;
        mediumCount = GameObject.Find("MediumCageCounter").GetComponent<CounterMedium>().count;
        largeCount = GameObject.Find("LargeCageCounter").GetComponent<CounterLarge>().count;

        count = smallCount + mediumCount + largeCount;
        counterText.text = $"Total: {count}";
    }
}
