using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get { return _Instance; } }
    private static GameManager _Instance;

    private static int score = 0;
    private static UIController uiController;

    public static int GetScore()
    {
        return score;
    }

    public static void SetScore(int _score)
    {
        score = _score;
    }

    public static void AddScore(int addScore)
    {
        score += addScore;
        uiController.UpdateScore();
        Debug.Log("current score: " + GetScore());
    }

    void Awake()
    {
        _Instance = this;
        uiController = GameObject.Find("/UI").GetComponent<UIController>();
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