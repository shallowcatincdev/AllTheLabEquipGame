using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentValue : MonoBehaviour
{

    public int hits;
    public int time;


    // Start is called before the first frame update
    void Start()
    {

        DontDestroyOnLoad(this); //should be the code that doesnt kill the object across scenes


    }//end start

}//end class
