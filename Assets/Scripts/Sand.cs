using UnityEngine;
using System.Collections;

public class Sand : MonoBehaviour {

	private GameObject mainCamera;
	public int destroyDistance = -40;
	public float speed = -15f;
	public float positiony = -2.194483f;
	private SubmarineControl submarine;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindWithTag ("MainCamera");
		submarine = GameObject.Find ("submarine").GetComponent<SubmarineControl>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!submarine.isEndGame())
			transform.Translate(new Vector2 (speed * Time.deltaTime, 0));
		if (transform.position.x - mainCamera.transform.position.x < destroyDistance) {
			transform.position = new Vector2(47.0f,positiony);
		}
	}
}
