using UnityEngine;
using System.Collections;
using System;

public class Sound : MonoBehaviour {

	private bool mute = true;
	public Texture soundOn;
	public Texture soundOff;
	private GameObject music;
	private int iconSize = 64;

	// Use this for initialization
	void Start () {
		music = GameObject.Find ("music and AdMob");
	    mute = PlayerPrefs.GetInt ("mute", 1) != 0;
		guiTexture.pixelInset = new Rect (Screen.width - iconSize, 0, iconSize, iconSize);
		setAudio ();
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
		guiTexture.texture = mute ? soundOff : soundOn;
		music.audio.volume = Convert.ToInt32(!mute);
	}

	public bool isMute() {
		return mute;
	}
}
