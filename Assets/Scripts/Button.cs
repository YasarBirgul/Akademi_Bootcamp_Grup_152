using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public CollisionGulliotine _collisionGulliotine;
    
    // Start is called before the first frame update
    void Start()
    {
        _collisionGulliotine = GetComponent<CollisionGulliotine>();
    } 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GetComponent<Animator>().enabled = true;
            _collisionGulliotine.GulliotineStop();
        } 
    }
}
