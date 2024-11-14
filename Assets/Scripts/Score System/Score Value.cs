using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreValue : MonoBehaviour
{
    public float score;
    public GameObject persistentObject;
    public PersistentValue persistentValue;

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
    void Awake()
    {
        /*
        //for testing methods
        AddScore(add);
        RemoveScore(minus);
        */

        try
        {
            persistentObject = GameObject.FindGameObjectWithTag("Persistent Value");
            Debug.Log("persistent object found");
        }//end try
        catch
        {
            Debug.Log("persistent object not found");
        }//end catch

        //if persistent object = true (if there IS a persistent object present)
        if (persistentObject)
        {
            //pulls ScoreValue script from gameobject
            persistentValue = persistentObject.GetComponent<PersistentValue>();
            Debug.Log("found persistent object code");
        }//end if
        else
        {
            Debug.Log("persistent object code not found");
        }//end else

        try
        {
            score = persistentValue.score;
            Debug.Log("found persistent score");
        }//end try

        catch
        {
            Debug.Log("persistent score not found");
        }//end catch


    }//end start

    // Update is called once per frame
    void Update()
    {
        

    }//end update
}
