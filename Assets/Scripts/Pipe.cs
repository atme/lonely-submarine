using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour {

	private bool stopUse = false;

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Finish" && stopUse == false) {
			transform.parent = null;
			gameObject.AddComponent<Rigidbody2D>();
			stopUse = true;
		}
	}
}