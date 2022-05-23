using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectSpawner : MonoBehaviour
{ 
    private int instanceNumber = 1;
    public GameObject entityToSpawn;
    public VariousPipesList spawnManagerValues;
    [SerializeField] public Quaternion rotation = Quaternion.identity;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnties();
    }
    void SpawnEnties()
    {
        int currentSpawnPointIndex = 0;

        for (int i = 0; i < spawnManagerValues.numberOfPrefabsToCreate; i++)
        {
            // Creates an instance of the prefab at the current spawn point.
            GameObject currentEntity = Instantiate(entityToSpawn,
                spawnManagerValues.spawnPoints[currentSpawnPointIndex], rotation);

            // Sets the name of the instantiated entity to be the string defined in the ScriptableObject and then appends it with a unique number. 
            currentEntity.name = spawnManagerValues.prefabName + instanceNumber;

            // Moves to the next spawn point index. If it goes out of range, it wraps back to the start.
            currentSpawnPointIndex = (currentSpawnPointIndex + 1) % spawnManagerValues.spawnPoints.Length;

            instanceNumber++;

        }


    }
}
