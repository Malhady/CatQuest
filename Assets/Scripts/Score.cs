using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score
{
    private static int scoreCount;

    public static int ScoreCount
    {
        get 
        {
            return scoreCount;
        }
        set 
        {
            scoreCount = value;
        }
    }
}