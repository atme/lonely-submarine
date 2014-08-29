using UnityEngine;
using System.Collections;

public class Mine : MonoBehaviour {
	private GameObject mainCamera;
	private int destroyDistance = -15;
	private float speed = 0.3f;
	private SubmarineControl submarine;
	private bool sailedSubmarine = false;
	private int submarinePosition = -2;
	private float bottomBorderOfUpperMine = 2f;
	private int mineRenderDistant = 20;

	// Use this for initialization
	void Start () {
		mainCamera = GameObject.FindWithTag ("MainCamera");
		submarine = GameObject.Find ("submarine_limbov3.5").GetComponent<SubmarineControl>();
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x - mainCamera.transform.position.x < destroyDistance) {
			if (transform.position.y > bottomBorderOfUpperMine)
				transform.position = new Vector2(mineRenderDistant, Random.Range (4f, bottomBorderOfUpperMine));
			else
				transform.position = new Vector2(mineRenderDistant, bottomBorderOfUpperMine - Random.Range (5f, 1f));
			
			sailedSubmarine = false;
		}

		if (transform.position.x < submarinePosition && !sailedSubmarine) {
			sailedSubmarine = true;
			submarine.AddScore();
		}

		if (!submarine.isEndGame())
			transform.position = new Vector2 (transform.position.x - speed, transform.position.y);
	}
}
