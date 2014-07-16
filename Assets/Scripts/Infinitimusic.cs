using UnityEngine;
using System.Collections;

public class Infinitimusic : MonoBehaviour {

	public static Infinitimusic instance = null;
	// Use this for initialization
	void Start () {
		if(instance!=null){
			Destroy(gameObject);
			return;
		}
		instance = this;
		DontDestroyOnLoad (gameObject);
		//if(GlobalOptions.isSound()){
		audio.Play();
		//}
	}
	
	public void Pause(){
		audio.Pause();
	}
	
	public void Play(){
		audio.Play();
	}
}
