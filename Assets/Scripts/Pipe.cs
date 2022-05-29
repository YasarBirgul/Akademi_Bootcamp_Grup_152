using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
     public PipeRevolver _PipeRevolveInput;
    private Transform pipeTransformVal;
    private PipeGen _pipeGenerator;
    // Start is called before the first frame update
    void Start()
    {
        _PipeRevolveInput = GetComponent<PipeRevolver>();
        pipeTransformVal = GetComponent<Transform>();
        _pipeGenerator = GetComponent<PipeGen>();
    }
// Update is called once per frame
    public void Update()
    {
        PipeRevolve();
    }

    void PipeRevolve()
    {
        _PipeRevolveInput.RevolveInput(pipeTransformVal);
    }

}
