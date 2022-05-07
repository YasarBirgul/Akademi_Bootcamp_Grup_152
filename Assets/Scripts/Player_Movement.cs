using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{  
    // Player`s components
    [SerializeField] public Rigidbody theplayer;
    // Rigidbody Force rate 
    [SerializeField] public float forceRate;
    // Start is called before the first frame update
    // Catching
    void Start() {
        theplayer = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
    } 
    // Players Rigidbody Force for the main movement...
    private void FixedUpdate()
    {  
        theplayer.AddForce(transform.forward*forceRate);
    }
}
