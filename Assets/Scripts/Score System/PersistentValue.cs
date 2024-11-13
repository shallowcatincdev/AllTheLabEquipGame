using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentValue : MonoBehaviour
{
    //transferring values across scenes (according to josh)

    public float score;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject); //should be the code that doesnt kill the object across scenes
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
