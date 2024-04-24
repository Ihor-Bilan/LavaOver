using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    
    private static int score;

   
    public static void IncreaseScore(int points)
    {
        score += points;
        Debug.Log("The account has been increased. Current account: " + score);
    }

    
    public static void ResetScore()
    {
        score = 0;
        Debug.Log("Account has been reset.");
    }

    void Start()
    {
       
        IncreaseScore(10);
    }
}
