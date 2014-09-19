using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class AdMob : MonoBehaviour {

	// Use this for initialization
	void Start () {
		BannerView bannerView = new BannerView(
			"ca-app-pub-6456127140143512/5089791385", AdSize.Banner, AdPosition.Bottom);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder()
		//	.AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
		//	.AddTestDevice("3a9b19efaaff7f5a")  // Test Device 1
			.Build();
		// Load the banner with the request.
		bannerView.LoadAd(request);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
