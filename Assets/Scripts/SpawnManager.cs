using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Spawn Space Options")]
    [SerializeField] float spawnPositionX;
    [SerializeField] float spawnPositionY;
    [SerializeField] float spawnPositionZ;
    [Header("Spawn Time Options")]
    [SerializeField] float respawnDelayMin;
    [SerializeField] float respawnDelayMax;

    private void Start()
    {
        SpawnAgents();
    }

    void SpawnAgents()
    {
        InvokeRepeating("SpawnAgentFromPool",0, Random.Range(respawnDelayMin, respawnDelayMax));
    }

    void SpawnAgentFromPool()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPositionX, spawnPositionX), spawnPositionY, Random.Range(-spawnPositionZ, spawnPositionZ));
               
    }
}
