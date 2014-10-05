using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	private float explosionTime = 0.55f;
	private float explosionPerFrame = 0.15f;


	// Use this for initialization
	void Start () {
		Destroy (gameObject, explosionTime);
	}
	
	// Update is called once per frame
	void Update () {
		if (name == "BOOMV3_0")
			gameObject.GetComponent<CircleCollider2D>().radius += explosionPerFrame;
	}
}