using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Canvass : MonoBehaviour
{
    int score = 0;
    private TMP_Text text;
    public static Action<int> Uevent;
    void Start()
    {
        text = transform.GetChild(0).GetComponent<TMP_Text>();
        Uevent = updateScore;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Current score: " + score.ToString();
    }

    void updateScore(int score)
    {
        this.score += score;
    }
}
