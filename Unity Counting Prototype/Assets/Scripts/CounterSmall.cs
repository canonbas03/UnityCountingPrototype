using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterSmall : MonoBehaviour
{
    public Text CounterText;

    public int count = 0;

    private void Start()
    {
        count = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        count += 1;
        CounterText.text = $"Small Count: {count}";
    }
}
