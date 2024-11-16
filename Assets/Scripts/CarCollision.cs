using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    public void Update()
    {
        try
        {
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<PersistentValue>().score = 10;
        }
        catch
        {

        }
    }
}