using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentManager : MonoBehaviour
{
    [SerializeField] GameObject presistent;
    /*
     * Fixes the issue of multiple persistent value instances appearing and fucking up the score
     * makes an array and puts every persistent value object into it
     * anything that isnt at the index of 0 is destroyed
     */

    // Start is called before the first frame update
    void Start()
    {

        Instantiate(presistent);


    }//end start

}//end class
