using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentValue : MonoBehaviour
{
    //transferring values across scenes (according to josh)
    //put a bunch of debug.log statements incase it doesnt work

    public GameObject scoreValue;
    public float score;
    public ScoreValue ScoreValue;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //should be the code that doesnt kill the object across scenes
        try
        {
            //finds the nearest object with score tag (should be just the score value)
            scoreValue = GameObject.FindGameObjectWithTag("Score"); 
            Debug.Log("found GameObject");
        }//end try
        catch
        {
            Debug.Log("GameObject not found");
        }//end catch
        
    }

    // Update is called once per frame
    void Update()
    {
        //if scorevalue object = true (if there IS a scorevalue object present)
        if (scoreValue)
        {
            //pulls ScoreValue script from gameobject
            ScoreValue = scoreValue.GetComponent<ScoreValue>();
            Debug.Log("found scorevalue code");
        }//end if
        else
        {
            Debug.Log("scorevalue code not found");
        }//end else

        try
        {
            //turns scorevalue's score value into persistent value's score
            score = ScoreValue.score;
        }//end try
        catch
        {
            Debug.Log("score not found");
        }//end catch

    }//end update
}//end class
