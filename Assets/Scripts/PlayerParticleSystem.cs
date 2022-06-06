using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerParticleSystem : MonoBehaviour
{
    public void ParticleState(ParticleSystem systemname, bool state)
    {
        systemname.GameObject().SetActive(state);
    }
}
