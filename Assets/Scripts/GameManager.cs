using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class GameManager : MonoBehaviour
{
    public BallBehavior ball;

    public TMP_Text Player1Text,Player2Text;

    private int Player1Score,Player2Score;

    public void Player1Scores()
    {
        Player1Score++;
        Player1Text.text = Player1Score.ToString();

        ball.ResetPos();

    }

    public void Player2Scores()
    {
        Player2Score++;
        Player2Text.text = Player2Score.ToString();

        ball.ResetPos();

    }
}
