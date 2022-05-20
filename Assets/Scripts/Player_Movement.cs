using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    [SerializeField] private HealthController _healthController;
    private float width;
    // Player`s components
    public Animator _playerAnimator;

    private Transform _playerTransform;
    // Rigidbody Force rate 
    [SerializeField] public float forceRate;

    private bool forceRateDesrease=false;
    public ParticleSystem _explotion;

    private void Awake()
    {   
        width = (float) Screen.width / 2.0f;
        _playerAnimator = GetComponent<Animator>();
                _playerTransform = GetComponent<Transform>();
    }

    void Start() {
         Screen.sleepTimeout = SleepTimeout.NeverSleep;
        // _healthController = GetComponent<HealthController>();

    }
    // Update is called once per frame
    void Update()
    {   
        // This refers to score method ScoreIncrease()
        Score.og2d.ScoreIncrease(transform.position.z);

        // Main Movement 
        transform.Translate(0,0,forceRate*Time.deltaTime);

         // Jump with Touch 
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

    public void OnCollisionEnter(Collision other)
    {
        
 
        if (other.gameObject.CompareTag("OBS") && forceRateDesrease == false)
        {
            _healthController.playerHealth -= 1;
            _healthController.UpdateHealth();
            forceRateDesreaseHalf();
            Invoke("forceRateBackToNormal",3f);
            Destroy(other.gameObject); // Can be changed 
        }
    } 
    void forceRateDesreaseHalf()
    {
        forceRate = forceRate / 2;
        forceRateDesrease = true;
        GetComponent<Collider>().isTrigger = true;
        _explotion.Play();
    }
    void forceRateBackToNormal()
    {
        forceRate = forceRate * 2;
        forceRateDesrease = false;
        GetComponent<Collider>().isTrigger = false;
        _explotion.Stop();
    }
    
    
    
    
    
    
}
