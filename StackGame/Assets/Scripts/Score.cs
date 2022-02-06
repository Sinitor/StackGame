using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{

    private int score;
    private TextMeshProUGUI text;
    private void Start()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
        GameManager.onCubeSpawned += GameManager_onCubeSpawned;
    }

    private void OnDestroy()
    {
        GameManager.onCubeSpawned -= GameManager_onCubeSpawned;
    }
    private void GameManager_onCubeSpawned()
    {
        score++;
        text.text = "Score: " + score;
        if (score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", score);
        }
    }
}
