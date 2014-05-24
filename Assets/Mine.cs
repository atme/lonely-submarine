using UnityEngine;
using System.Collections;

public class Mine : MonoBehaviour {
	private GameObject camera;
	private int destroyDistance = -20;

	// Use this for initialization
	void Start () {
		camera = GameObject.FindWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x - camera.transform.position.x < destroyDistance)
			Destroy (this.gameObject);
	}
}
