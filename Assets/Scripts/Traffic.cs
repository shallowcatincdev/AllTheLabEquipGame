using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traffic : MonoBehaviour
{
    public List<GameObject> cars = new List<GameObject> { };

    public float maxSpeed;
    public float minSpeed;
    float speed;

    public float maxFollow;
    public float minFollow;
    float follow;

    int delay;
    public bool lead;

    private void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        follow = Random.Range(minFollow, maxFollow);
        delay = Random.Range(0, 600);
    }

    

    private void FixedUpdate()
    {
        if (lead)
        {
            transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.forward * ((minSpeed + maxSpeed) / 2) / 100, (minSpeed + maxSpeed) / 2 / 100);
        }
        else
        {
            delay++;

            if (delay % 300 == 0)
            {
                speed = Random.Range(minSpeed, maxSpeed);
                follow = Random.Range(minFollow, maxFollow);
            }

            if (cars.Count == 0)
            {
                transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.forward * (speed + 3) / 100, speed + 3 / 100);
            }
            else if (transform.position.z < cars[0].transform.position.z - follow)
            {
                transform.position = Vector3.MoveTowards(transform.position, cars[0].transform.position - Vector3.back * follow, speed / 100);
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, transform.position + Vector3.forward * minSpeed / 100, minSpeed / 100);
            }
        }
        

       
    }
}
