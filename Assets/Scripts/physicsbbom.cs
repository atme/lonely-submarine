using UnityEngine;
using System.Collections;

public class physicsbbom : MonoBehaviour {

	public float boomv;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<CircleCollider2D> ().radius = boomv;
		for (int i = 0; i < 4; i++) {
			boomv += 0.05f;
		}
	}
}