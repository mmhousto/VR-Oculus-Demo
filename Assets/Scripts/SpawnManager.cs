using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab;

    private float enemiesInWave = 2f;

    private bool spawnedFirstWave = false;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemies((int)enemiesInWave);
        spawnedFirstWave = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnedFirstWave && !GameObject.FindWithTag("Enemy"))
        {
            enemiesInWave *= 1.5f;

            SpawnEnemies((int)enemiesInWave);
        }
    }

    private void SpawnEnemies(int enemiesToSpawn)
    {
        for(int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, new Vector3(Random.Range(-12.0f, 35.0f), 1f, Random.Range(-30.0f, 16.75f)), Quaternion.identity);
        }
    }
}
