using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{   
    
    public Animator _playerAnimator;
    void Start()
    {
        _playerAnimator = GetComponent<Animator>();
    }

     public void Jump()
    {
        _playerAnimator.SetBool("jump_touch", true);
        
    }

    public void JumpReset()
    {
        
        _playerAnimator.SetBool("jump_touch", false);
        
    }
    
    
    
}
