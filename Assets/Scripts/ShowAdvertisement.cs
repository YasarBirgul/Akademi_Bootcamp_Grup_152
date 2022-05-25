using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Ad.Example;
using Unity.Services.Mediation;
using UnityEngine;
using UnityEngine.XR;

public class ShowAdvertisement : MonoBehaviour
{
    private Mediation _ad;

    private void Awake()
    {
        _ad = GetComponent<Mediation>();
        
    }
    // Start is called before the first frame update
    void Start()
    { 
        _ad.InitServices();
        _ad.SetupAd();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void myFunction()
    {
        _ad.ShowAd();
    }
}
