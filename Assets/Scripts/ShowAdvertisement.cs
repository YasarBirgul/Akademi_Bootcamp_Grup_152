using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Ad.Example;
using UnityEngine;

public class ShowAdvertisement : MonoBehaviour
{
    private InterstitialAdExample _ad;

    private void Awake()
    {
         _ad = new InterstitialAdExample();
        _ad.InitServices();
       
    }

    // Start is called before the first frame update
    void Start()
    {
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
