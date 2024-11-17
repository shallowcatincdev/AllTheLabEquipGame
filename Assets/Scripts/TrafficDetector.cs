using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficDetector : MonoBehaviour
{
    [SerializeField] Traffic car;
    public List<GameObject> cars;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Traffic" || other.gameObject.tag == "Player")
        {
            if (!cars.Contains(other.gameObject))
            {
                cars.Add(other.gameObject);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Traffic" || other.gameObject.tag == "Player")
        {
            if (cars.Contains(other.gameObject))
            {
                cars.Remove(other.gameObject);
            }
        }
    }

    private void Update()
    {
        car.cars = cars;
    }
}
