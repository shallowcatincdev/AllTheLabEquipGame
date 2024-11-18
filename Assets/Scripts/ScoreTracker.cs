using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    [SerializeField] GameObject presis;
    bool stop;

    int hits;
    int time;
    void Start()
    {


    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Traffic")
        {
            hits++;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time++;

        if (!stop)
        {
            presis.GetComponent<PersistentValue>().hits = hits;
            presis.GetComponent<PersistentValue>().time = time;
        }
    }
}
