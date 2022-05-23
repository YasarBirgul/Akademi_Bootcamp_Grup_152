using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data",menuName = "ScriptableObjects/VariousObjects",order =1)]
public class VariousPipesList : ScriptableObject
{   
    public string prefabName;
    public int numberOfPrefabsToCreate;
    public Vector3[] spawnPoints;
    public GameObject[] pipesTypes;
}
