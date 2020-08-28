using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class LogicaAds : MonoBehaviour
{
    private InterstitialAd interstitialAd;
    [SerializeField] private string appID = "";
    [SerializeField] private string interstitialID = "";


    // Start is called before the first frame update
    void Start()
    {
        PedirInterstitial();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void awake()
    {
        MobileAds.Initialize(appID);
    }


    private void PedirInterstitial()
    {
        interstitialAd = new InterstitialAd(interstitialID);
        AdRequest pedir = new AdRequest.Builder().Build();
        interstitialAd.LoadAd(pedir);
    }
}
