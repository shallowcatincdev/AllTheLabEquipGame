using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreValue : MonoBehaviour
{
    public float score;

    /*
    //used for testing the methods
    [SerializeField] float add;
    [SerializeField] float minus;
    */
    
    //requests a value then adds/subtracts value into score
    public float AddScore(float addscore)
    {
        return score += addscore;
    }//end method
    public float RemoveScore(float minusscore) {
        return score -= minusscore; 
    }//end method

    // Start is called before the first frame update
    void Start()
    {
        /*
        //for testing methods
        AddScore(add);
        RemoveScore(minus);
        */

    }//end start

    // Update is called once per frame
    void Update()
    {
        
    }//end update
}
