using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeGenerator : MonoBehaviour
{
    public VariousPipesList _variousPipesList;
    
    private int randomInt;
    private Vector3 platformSpawnPoint;
    [SerializeField] public Quaternion rotation = Quaternion.identity;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (gameObject.GetComponent<SphereCollider>().isTrigger)
            {
                spawnRandomPipes();
            }
        }
    }

    void spawnRandomPipes()
    {
        randomInt = Random.Range(0, _variousPipesList.pipesTypes.Length);
        platformSpawnPoint = new Vector3(0, 0, gameObject.transform.position.z + (10 *_variousPipesList.numberOfPrefabsToCreate));
        Instantiate(_variousPipesList.pipesTypes[randomInt], platformSpawnPoint, rotation);
        Destroy(gameObject);
    }

   
}
