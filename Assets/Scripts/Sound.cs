using UnityEngine;
using System.Collections;
using System;

public class Sound : MonoBehaviour {

	private bool mute = true;
	public Sprite soundOn;
	public Sprite soundOff;
	private GameObject music;
	private int iconSize = 64;
	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = gameObject.GetComponent<SpriteRenderer>();;
		music = GameObject.Find ("music and AdMob");
	    mute = PlayerPrefs.GetInt ("mute", 1) != 0;
		//guiTexture.pixelInset = new Rect (Screen.width - iconSize, 0, iconSize, iconSize);
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
		spriteRenderer.sprite = mute ? soundOff : soundOn;
		music.audio.volume = Convert.ToInt32(!mute);
	}

	public bool isMute() {
		return mute;
	}
}
