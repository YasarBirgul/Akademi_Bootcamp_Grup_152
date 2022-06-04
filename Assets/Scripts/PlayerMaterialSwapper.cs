using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMaterialSwapper : MonoBehaviour
{
    public Material Material1;
    public GameObject mesh;
    public Material MaterialNorm;
    public GameObject player;
    public Material materialDamage;
    public void changeMat(Material material)
    {
        mesh.GetComponent<SkinnedMeshRenderer>().material = material;
    }
    
}
