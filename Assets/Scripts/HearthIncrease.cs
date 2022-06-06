using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HearthIncrease : MonoBehaviour
{
   [SerializeField]
   private HealthController _healthController;

   private void Awake()
   {
      _healthController = GetComponent<HealthController>();
   }


   private void OnCollisionEnter(Collision other)
   {
      
      if (other.gameObject.CompareTag("health"))
      {
         if (_healthController.playerHealth < 3)
         {
            _healthController.playerHealth += 1;
            _healthController.UpdateHealth();
            
         }
         Destroy(other.gameObject);
      }
      
   }
}
