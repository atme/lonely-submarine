using UnityEngine;
using System.Collections;

public class boom : MonoBehaviour {

	public float timeforboom = 0.55f;


	// Use this for initialization
	void Start () {
		Destroy (gameObject, timeforboom);
	}
	
	// Update is called once per frame
	void Update () {

	}
}