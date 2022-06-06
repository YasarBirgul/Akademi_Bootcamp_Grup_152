using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMaterialSwapper : MonoBehaviour
{   // SpeedUp Skin of the character
    public Material MaterialSpeed;
    // Normal Skin of the character
    public Material MaterialNorm;
    // Damaged Skin of the character
    public Material materialDamage;
    [SerializeField]
    private GameObject _mesh;
    public void changeMat(Material material)
    {
        _mesh.GetComponent<SkinnedMeshRenderer>().material = material;
    }
    
}
