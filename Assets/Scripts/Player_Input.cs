using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Input : MonoBehaviour
{
    public Animator _playerAnimator;
    void Start()
    {
        _playerAnimator = GetComponent<Animator>();
    }
    public void Jump()
    {
        if (Input.touchCount != 0)
        {    
            Touch touch = Input.GetTouch(0);
            if (Input.GetTouch(0).phase == TouchPhase.Moved && touch.deltaPosition.y > 15f)
            {
                _playerAnimator.SetBool("jump_touch", true);
                Invoke("setBoolBack",1f);
            }
            
        }
        
    }
    public void setBoolBack()
    {
        _playerAnimator.SetBool("jump_touch", false);
    }
}
