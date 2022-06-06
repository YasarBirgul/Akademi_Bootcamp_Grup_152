using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Player_Input : MonoBehaviour
{
    [SerializeField]
    private AnimationManager _animationManager;
    private void Awake()
    {
        _animationManager = GetComponent<AnimationManager>();
    }
    private void Update()
    {
             // Jump Swipe Input 
             if (Input.touchCount != 0)
             {    
                 
                 Touch touch = Input.GetTouch(0);
                 if ( Input.GetTouch(0).deltaPosition.y > 5 )
                 {
                     _animationManager.Jump();
                 }
                 else
                 {
                     _animationManager.JumpReset();
                 }
             }

    }
}
