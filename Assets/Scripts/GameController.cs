﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public Text timerText;
    public Text scoreText;

    private float timer = 100f;
    private float score = 0f;

    // Use this for initialization
    void Start()
    {
        timerText.text = Mathf.Round(timer).ToString();
        scoreText.text = "Score : " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = Mathf.Round(timer).ToString();
        if (timer <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("Metal_Slug");
    }

    void IncreaseScore(float scoreInc)
    {
        score += scoreInc;
        scoreText.text = "Score : " + score.ToString();
    }
}
