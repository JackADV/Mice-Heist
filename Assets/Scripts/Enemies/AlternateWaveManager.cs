using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct AlternateWave
{
    public int enemies;
    public float minSpawnRate, maxSpawnRate;
    public float delayToNext;
    public bool isRunning;
}

public class AlternateWaveManager : MonoBehaviour
{
    public bool gameOver = false;
    public Wave[] waveSettings;
    public GameObject[] enemyPrefabs;
    public int waveIndex = 0;

    private Transform[] points;
    private int enemyCount = 0;

    #region Unity Events
    void Start()
    {
        Transform[] children = GetComponentsInChildren<Transform>();
        points = new Transform[children.Length - 1];
        for (int i = 1; i < children.Length; i++)
        {
            points[i - 1] = children[i];
        }

        StartNextWave();
    }

    IEnumerator StartWave(Wave currentWave)
    {
        while (enemyCount < currentWave.enemies) 
		{
			enemyCount++;

            int randPoint = Random.Range(0, points.Length);
            Transform point = points[randPoint];

            // Spawn enemy
            int randEnemy = Random.Range(0, enemyPrefabs.Length);
            GameObject prefab = enemyPrefabs[randEnemy];
			Instantiate(prefab, point.position, point.rotation);

            float rate = Random.Range(currentWave.minSpawnRate, currentWave.maxSpawnRate);

            yield return new WaitForSeconds(rate);
		}
        
        // If no enemies are left
        yield return new WaitForSeconds(currentWave.delayToNext);

        // Start new wave
        StartNextWave();

        enemyCount = 0;
        
        print("Current Wave: " + (waveIndex + 1) + "");
    }

    void StartNextWave()
    {
        // Get current wave
        Wave currentWave = waveSettings[waveIndex];
        // Run coroutine for spawning enemies on point
        StartCoroutine(StartWave(currentWave));
        // Increase index (for next wave)
        waveIndex++;
    }
    
    #endregion
    
}