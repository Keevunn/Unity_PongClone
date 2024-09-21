using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Attributes
    private int _playerScore;
    private int _computerScore;

    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text playerScoreText;
    public Text computerScoreText;

    public void PlayerScores()
    {
        _playerScore++;
        ball.ResetPosition();
        playerScoreText.text = _playerScore.ToString();
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
    }
    
    public void ComputerScores()
    {
        _computerScore++;
        ball.ResetPosition();
        computerScoreText.text = _computerScore.ToString();
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
    }
}
