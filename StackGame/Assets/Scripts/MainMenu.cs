using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 
using TMPro;

public class MainMenu : MonoBehaviour
{
    public TextMeshProUGUI HStext;
    private void Start()
    {
        HStext.text = "HIGHSCORE: " + PlayerPrefs.GetInt("highscore"); 
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
