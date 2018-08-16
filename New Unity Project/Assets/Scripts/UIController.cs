using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private Text scoreUIText;
    private string scoreText = "0";

    void Awake()
    {
        scoreUIText = GameObject.Find("/UI/ScoreText").GetComponent<Text>();
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