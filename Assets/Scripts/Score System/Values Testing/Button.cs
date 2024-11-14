using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    //just for proof-of-concept stuffs to show that the score methods can be used

    [SerializeField] ScoreValue ScoreValue;

    public void AdditionScore()
    {
        ScoreValue.AddScore(100);
    }

    public void SubtractionScore()
    {
        ScoreValue.RemoveScore(100);
    }

}//end class
