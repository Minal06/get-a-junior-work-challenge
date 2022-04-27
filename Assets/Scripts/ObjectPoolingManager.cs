using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolingManager : MonoBehaviour
{
    [System.Serializable]

    public class agentPool
    {
        public string tag;
        public GameObject objectToPool;
        public int amountToPool;
    }

    public List<agentPool> a_pool;
    public Dictionary<string, Queue<GameObject>> pooledAgents;


    #region Singleton
    public static ObjectPoolingManager SharedInstance { get; private set; }
    private void Awake()
    {
        SharedInstance = this;
    }
    #endregion
    
    void Start()
    {
        pooledAgents = new Dictionary<string, Queue<GameObject>>();

        foreach (agentPool pool in a_pool)
        {
            Queue<GameObject> objectPool = new Queue<GameObject>();

            for (int i = 0; i < pool.amountToPool; i++)
            {
                GameObject obj = Instantiate(pool.objectToPool);
                obj.SetActive(false);
                objectPool.Enqueue(obj);
                obj.transform.SetParent(this.transform);
            }
            pooledAgents.Add(pool.tag, objectPool);
        }
    }

    public GameObject SpawnFromPool(string tag, Vector3 position, Quaternion rotation)
    {
        if (!pooledAgents.ContainsKey(tag))
        {
            Debug.LogWarning("tag is not correct");
            return null;
        }

        GameObject objectToSpawn = pooledAgents[tag].Dequeue();

        objectToSpawn.SetActive(true);
        objectToSpawn.transform.position = position;
        objectToSpawn.transform.rotation = rotation;

        pooledAgents[tag].Enqueue(objectToSpawn);

        return objectToSpawn;
    }
}
