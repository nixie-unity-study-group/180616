using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get { return _Instance; } }
    private static GameManager _Instance;

    private static int score = 0;
    private static UIController uiController;
    private static GameObject player;

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

    public static void ShowRestartButton()
    {
        uiController.ShowRestartButton();
    }

    public void HideRestartButton()
    {
        uiController.HideRestartButton();
    }

    public void RestartPlayer() {
        Debug.Log("restart");
        score = 0;
        player.SetActive(true);
        player.transform.position = new Vector2(0.0f, -3.64f);
    }

    void Awake()
    {
        _Instance = this;
        uiController = GameObject.Find("/UI").GetComponent<UIController>();
        player = GameObject.Find("/Player");
    }

    // Use this for initialization
    void Start()
    {
        HideRestartButton();
    }

    // Update is called once per frame
    void Update()
    {

    }
}