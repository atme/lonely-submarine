using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {

	private bool breakpipe;
	private bool stopuse;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (breakpipe == true) {
			transform.parent = null;
			gameObject.AddComponent<Rigidbody2D>();
			stopuse = true;
			breakpipe = false;
			Destroy(gameObject, 2.0f);
		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Finish" && stopuse == false) {
				breakpipe = true;
		}
	}
}