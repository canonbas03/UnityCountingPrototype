using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterLarge : MonoBehaviour
{
    public Text counterText;

    public int count = 0;

    private void Start()
    {
        count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        count += 1;
        counterText.text = $"Large Count: {count}";
    }
}
