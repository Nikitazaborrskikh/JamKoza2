using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public static class ScoreAdd                
{
    
     public static int score = 0;



    public static void AddScore()
    {
        score += 100;
        
    }

    public static int  ScoreCount()
    {
        return score;
        
    }
}
