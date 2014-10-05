using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class AdMob : MonoBehaviour {
	protected BannerView bannerView;
	public InterstitialAd interstitial;

	// Use this for initialization
	void Start () {
		bannerView = new BannerView(
			"ca-app-pub-6456127140143512/5089791385", AdSize.Banner, AdPosition.Bottom);
		// Create an empty ad request.
		AdRequest request = new AdRequest.Builder()
		//	.AddTestDevice(AdRequest.TestDeviceSimulator)       // Simulator.
		//	.AddTestDevice("3a9b19efaaff7f5a")  // Test Device 1
			.Build();
			
		bannerView.LoadAd(request);
		// Initialize an InterstitialAd.
		//interstitial = new InterstitialAd("ca-app-pub-6456127140143512/5089791385");
		// Create an empty ad request.
		//AdRequest request = new AdRequest.Builder().Build();
		// Load the interstitial with the request.
		//interstitial.LoadAd(request);
	}
}
