using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarCollision : MonoBehaviour
{
    public float score = 0;

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Traffic")
        {
                Debug.Log("Collision");
                score += 100;
                GameObject.FindGameObjectWithTag("GameManager").GetComponent<PersistentValue>().score += 5;
      
        }
    }
}