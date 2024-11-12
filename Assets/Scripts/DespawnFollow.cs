using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnFollow : MonoBehaviour
{
    [SerializeField] GameObject car;
    private void Update()
    {
        transform.position = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z - 100);
    }
}
