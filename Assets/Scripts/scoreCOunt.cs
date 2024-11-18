using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class scoreCOunt : MonoBehaviour
{
    [SerializeField] TextMeshPro text;

    int hits;
    int time;

    int money = 2000;
    void Start()
    {
        
        try
        {
            hits = GameObject.FindGameObjectWithTag("Score").GetComponent<PersistentValue>().hits;
            time = GameObject.FindGameObjectWithTag("Score").GetComponent<PersistentValue>().time;

            Destroy(GameObject.FindGameObjectWithTag("Score"));
        }
        catch
        {

        }

        if (time < 8000)
        {
            money += (time - 4000) * -1;
        }

        money -= hits * 100;

        text.text = "You Made:$" + money;

    }


}
