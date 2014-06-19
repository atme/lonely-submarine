using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour {
	public GameObject mine;
	private static int mineDistance = 11;
	public GameObject sand;
	public GameObject background;
	public GameObject backgroundv2;
	private bool spawn;

	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateMine", 0.1f, 2f);
		InvokeRepeating("CreateSand", 0.9f, 1.37f);
		InvokeRepeating("CreateBackground", 3f, 3f);
		InvokeRepeating("CreateBackgroundv2", Random.Range (5f, 10f), Random.Range (5f, 10f));
	}
	
	// Update is called once per frame
	void Update () {

	}

	void CreateMine() {
		float upMinePosition = Random.Range (4.0f, 2.0f);
		Vector2 upPosition = new Vector2(transform.position.x + mineDistance, upMinePosition);
		Vector2 downPosition = new Vector2(transform.position.x + mineDistance, upMinePosition - Random.Range (5, 1));

		Instantiate(mine, upPosition, transform.rotation);
		Instantiate(mine, downPosition, transform.rotation);
	}

	void CreateSand() {
		Instantiate(sand, new Vector2 (35, -2), transform.rotation);
	}

	void CreateBackground() {
		Instantiate(background, new Vector2 (35, 1), transform.rotation);
	}

	void CreateBackgroundv2(){
		if (spawn == false) {
			Instantiate (backgroundv2, new Vector2 (22f, 2.2f), transform.rotation);
			spawn = true;
		}
	}

	public static int GetMineDistance() {
		return mineDistance;
	}

}
