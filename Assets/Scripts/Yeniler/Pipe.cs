using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Pipe : MonoBehaviour
{
    public PipeRevolveInput _PipeRevolveInput;
    private Transform pipeTransformVal;
    private PipeGenerator _pipeGenerator;
    // Start is called before the first frame update
    void Start()
    {
        _PipeRevolveInput = GetComponent<PipeRevolveInput>();
        pipeTransformVal = GetComponent<Transform>();
        _pipeGenerator = GetComponent<PipeGenerator>();
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
