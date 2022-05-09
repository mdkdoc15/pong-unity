using System;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1Paddle;

    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2Paddle;

    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject player1Text;

    public GameObject player2Text;

    private int player1Score = 0;
    private int player2Score = 0;

    public void Player1Scored()
    {
        ++player1Score;
        player1Text.GetComponent<TextMeshProUGUI>().text = player1Score.ToString();
        Reset();
    }

    public void Player2Scored()
    {
        ++player2Score;
        player2Text.GetComponent<TextMeshProUGUI>().text = player2Score.ToString();
        Reset();
    }

    private void Reset()
    {
        ball.GetComponent<BallMovement>().Reset();
        player1Paddle.GetComponent<PaddleMovement>().Reset();
        player2Paddle.GetComponent<PaddleMovement>().Reset();
        
    }
}