using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionGulliotine : MonoBehaviour
{
    private void Start()
    {
    }

    public void GulliotineStop()
    {
        GetComponent<Animator>().enabled = false;
        GetComponent<Collider>().enabled = false;
    }
    
}
