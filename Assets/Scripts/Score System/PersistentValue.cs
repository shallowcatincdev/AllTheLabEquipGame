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

    //values for debugging.log ONCE
    public bool scoreValueTxt;
    public bool scoreTxt;
    public bool gameObjectTxt;

    // Start is called before the first frame update
    void Start()
    {

        DontDestroyOnLoad(this.gameObject); //should be the code that doesnt kill the object across scenes

        scoreValueTxt = false;
        scoreTxt = false;
        gameObjectTxt = false;

    }//end start

    // Update is called once per frame
    void Update()
    {
        try
        {
            //finds the nearest object with score tag (should be just the score value)
            scoreValue = GameObject.FindGameObjectWithTag("Score");

            if (gameObjectTxt!) //plays once...
            {
                Debug.Log("found GameObject");
                gameObjectTxt = true;
            }//end if
            
        }//end try
        catch
        {
            if (gameObjectTxt!) //plays once...
            {
                Debug.Log("GameObject not found");
                gameObjectTxt = true;
            }//end if 

        }//end catch

        //if scorevalue object = true (if there IS a scorevalue object present)
        if (scoreValue)
        {
            //pulls ScoreValue script from gameobject
            ScoreValue = scoreValue.GetComponent<ScoreValue>();

            if (scoreValueTxt!) //plays once...
            {
                Debug.Log("found scorevalue code");
                scoreValueTxt = true;
            }//end if
            
        }//end if

        else
        {
            if (scoreValueTxt!) //plays once...
            {
                Debug.Log("scorevalue code not found");
                scoreValueTxt = true;
            }//end if

        }//end else

        try
        {
            //turns scorevalue's score value into persistent value's score
            score = ScoreValue.score;

            if (scoreTxt!) //plays once...
            {
                Debug.Log("score found");
                scoreTxt = true;
            }//end if 

            }//end try

        catch
        {
            if (scoreTxt!) //plays once...
            {
                Debug.Log("score not found");
                scoreTxt = true;
            }//end if
            
        }//end catch

    }//end update
}//end class
