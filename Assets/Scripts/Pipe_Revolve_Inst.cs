using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Revolve_Inst : MonoBehaviour
{   
    
    
    //// Pipe Components ////
    // Pipe Rotation Speed
    [SerializeField] public float pipeRotationSpeed = 5;
    // Pipe Transform info
    [SerializeField] public Transform pipeTransformData;
    /// Pipe Spawner Components
    private float spawnPlatTo;
    private int randomInt;
    // Randomizer Float
    private float platformNumber;
    private Vector3 platformSpawnPoint;
    // Pipe Type list
    [SerializeField] public Quaternion rotation = Quaternion.identity;
    public GameObject[] spawnPipePlatforms;
    
    
    [SerializeField]
    public int addedPlatformNumb_AtBeginning;


    // Catching...
    void Start() {
      
        
        
        pipeTransformData = GetComponent<Transform>();
    }  
    // Rotation of the pipe by accelerator ınput
    void Update() {
        
        
        
        
        pipeTransformData.transform.Rotate(0, 0, Input.acceleration.x * pipeRotationSpeed, Space.World);
    }
    // Endless Pipe Generator
    private void OnTriggerEnter(Collider other)
    { 
        
        if (other.gameObject.CompareTag("Player")) 
        
        {
            spawnRandomPipes();
        }
    }

     // Pipe Randomizer 
    void spawnRandomPipes()
    {   randomInt = Random.Range(0, spawnPipePlatforms.Length);
        platformSpawnPoint = new Vector3(0, 0, gameObject.transform.position.z+(10*addedPlatformNumb_AtBeginning));
        Instantiate(spawnPipePlatforms[randomInt], platformSpawnPoint,rotation);
        Destroy(gameObject);
    } 
   
}
