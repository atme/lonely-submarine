using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {

	private bool breakPipe = false;
	private bool stopUse = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (breakPipe == true) {
			transform.parent = null;
			gameObject.AddComponent<Rigidbody2D>();
			stopUse = true;
			breakPipe = false;
			Destroy(gameObject, 2.0f);
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Finish" && stopUse == false) {
			breakPipe = true;
		}
	}
}