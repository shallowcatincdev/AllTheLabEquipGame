using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject car;
    public int spawnRate;
    public int spawnChance;

    int spawnDelay;

    private void FixedUpdate()
    {
        spawnDelay++;

        if (spawnDelay % (60 * spawnRate) == 0)
        {
            if (Random.Range(0, 100) < spawnChance)
            {
                Instantiate(car, transform);
            }
        }
    }
}
