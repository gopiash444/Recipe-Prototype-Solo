using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] spawnPoint;
    [SerializeField]
    GameObject objectPrefab; 

    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.FindGameObjectsWithTag("SpawnPoint");
        foreach (GameObject spawn in spawnPoint)
        {
            GameObject spawnSphere = Instantiate(objectPrefab, spawn.transform, false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
