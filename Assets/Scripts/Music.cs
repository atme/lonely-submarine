using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour {

	public static bool instance = false;
	// Use this for initialization
	void Start () {
		if (instance == true) {
			Destroy(gameObject);
			return;
		}
		instance = true;
		DontDestroyOnLoad (gameObject);
	}
}
