using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] ScoreValue scoreValue;
    [SerializeField] TextMeshProUGUI scoreDisplay;

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = scoreValue.score.ToString();
    }//end update

}//end class
