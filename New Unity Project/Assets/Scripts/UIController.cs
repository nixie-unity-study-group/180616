using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private Text scoreUIText;
    private string scoreText = "0";
    private GameObject restartButton;
    void Awake()
    {
        scoreUIText = GameObject.Find("/UI/ScoreText").GetComponent<Text>();
        restartButton = GameObject.Find("/UI/Restart");
    }

    public void ShowRestartButton()
    {
        restartButton.SetActive(true);
    }
    public void HideRestartButton()
    {
        restartButton.SetActive(false);
    }

     public void UpdateScore()
    {
        scoreText = GameManager.GetScore().ToString();
        scoreUIText.text = scoreText;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}