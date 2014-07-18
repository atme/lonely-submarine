using UnityEngine;
using System.Collections;
using System;

public class Sound : MonoBehaviour {

	private bool mute = true;
	public Texture2D soundOnTexture;
	public Texture2D soundOffTexture;
	private GameObject music;
	private int iconSize = 64;

	// Use this for initialization
	void Start () {
		music = GameObject.Find ("music and AdMob");
	    mute = PlayerPrefs.GetInt ("mute", 1) != 0;
		guiTexture.pixelInset = new Rect (Screen.width - iconSize, 0, iconSize, iconSize);
		setAudio ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	private void OnMouseDown() {
		toggleSound(); 
	}
	
	private void onTouchStart() {
		toggleSound(); 
	}

	private void toggleSound() {
		mute = !mute;
		PlayerPrefs.SetInt ("mute", Convert.ToInt32(mute));
		setAudio ();
	}

	private void setAudio() {
		guiTexture.texture = mute ? soundOffTexture : soundOnTexture;
		music.audio.volume = Convert.ToInt32(!mute);
	}

	public bool isMute() {
		return mute;
	}
}
