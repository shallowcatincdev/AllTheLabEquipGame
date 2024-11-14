using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManager : MonoBehaviour
{
    public GameObject[] objects;

    /*
     * Fixes the issue of multiple persistent value instances appearing and fucking up the score
     * makes an array and puts every persistent value object into it
     * anything that isnt at the index of 0 is destroyed
     */

    // Start is called before the first frame update
    void Start()
    {
        objects = GameObject.FindGameObjectsWithTag("Persistent Value");

        foreach (GameObject i in objects)
        {
            if (objects.Length >= 2)
            {
                Destroy(objects[objects.Length - 1]);
            }//end if

        }//end foreach

    }//end start

}//end class
