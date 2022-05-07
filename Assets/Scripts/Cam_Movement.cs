using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Movement : MonoBehaviour
{   
    private Camera _cam;
    public GameObject player;

    // Catching
    void Start()
    {
        _cam = GetComponent<Camera>();
        _cam= Camera.main;
    }
    
    // Positioning Camera
    private void LateUpdate()
    {
        _cam.transform.position = new Vector3(0,0, player.transform.position.z-5);
    }
}
