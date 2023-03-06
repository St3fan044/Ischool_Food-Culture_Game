using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    public Transform MinSpawnLimit;
    public Transform MaxSpawnLimit;

    public float SpoonEachTimer;
    float timer = 0;

    public GameObject[] EnemyList;

    void Start()
    {
        
    }

    void Update()
    {
        if (timer >= SpoonEachTimer)
        {
            int RandomIndex = Random.Range(0, EnemyList.Length);
            GameObject RandomEnemy = EnemyList[RandomIndex];

            float RandomX = Random.Range(MinSpawnLimit.position.x, MaxSpawnLimit.position.x);
            Vector3 SpawnPosition = new Vector3(RandomX, MinSpawnLimit.position.y, 0);
            SpawnEnemy(RandomEnemy, SpawnPosition);

            timer = 0;
        }
        else { timer += Time.deltaTime; }
    }

    public void SpawnEnemy(GameObject enemy, Vector3 SpawnPosition)
    {
        Instantiate(enemy, SpawnPosition, Quaternion.identity);
    }
}
