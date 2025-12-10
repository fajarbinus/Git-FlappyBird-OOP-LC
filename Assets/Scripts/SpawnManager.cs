using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float heightRange = 2f;
    [SerializeField] private float spawnRate = 2f;

    void Start()
    {
        StartCoroutine(SpawnPipesRoutine());
    }

    IEnumerator SpawnPipesRoutine()
    {
        while (!GameManager.Instance.IsGameStarted())
        {
            yield return null;
        }

        while (true)
        {
            //Debug.Log("Spawn!");
            //SpawnPipe();
            if (GameManager.Instance.IsGameStarted() && !GameManager.Instance.IsGameOver())
            {
                SpawnPipe();
            }
            yield return new WaitForSeconds(spawnRate);
        }
    }
    void SpawnPipe()
    {
        if (pipePrefab == null) Debug.Log("Prefab not assigned in SpawnManager!");
        float randomY = Random.Range(-heightRange, heightRange);
        Vector3 spawnPosition = new Vector3(10f,randomY,0);
        Instantiate(pipePrefab, spawnPosition, Quaternion.identity);

    }




}
