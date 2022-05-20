using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_Revolve_Inst : MonoBehaviour
{
    public GameObject player;
    private Vector3 MovePosition;
    private float width;
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
    void Awake() {
      
        width = (float) Screen.width / 2.0f;
        
        pipeTransformData = GetComponent<Transform>();
    }  
    // Rotation of the pipe by accelerator ınput
    void Update() {

        if (Input.touchCount > 0 )
        {
            Touch touch = Input.GetTouch(0);
            Vector3 pos = touch.position;
            pos.x = (pos.x - width) / width;
            MovePosition= new Vector3(pos.x, 0.0f, 0.0f);
            pipeTransformData.transform.Rotate(0,0,-MovePosition.x*2.5f,Space.World);
           
        }
        
    }
    // Endless Pipe Generator
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

     // Pipe Randomizer 
    void spawnRandomPipes()
    {   randomInt = Random.Range(0, spawnPipePlatforms.Length);
        platformSpawnPoint = new Vector3(0, 0, gameObject.transform.position.z+(10*addedPlatformNumb_AtBeginning));
        Instantiate(spawnPipePlatforms[randomInt], platformSpawnPoint,rotation);
        Destroy(gameObject);
    } 
   
}
