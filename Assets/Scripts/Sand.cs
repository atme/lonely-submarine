using UnityEngine;
using System.Collections;

public class Sand : MonoBehaviour {

	private GameObject mainCamera;
	private int destroyDistance = -20;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(new Vector2 (-15 * Time.deltaTime,0));
		if (transform.position.x - mainCamera.transform.position.x < destroyDistance) {
				Destroy (this.gameObject);
		}
	}
}
