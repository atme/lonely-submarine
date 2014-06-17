using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour {
	public GameObject mine;
	private static int mineDistance = 11;
	public GameObject floorwithgrass;

	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateMine", 0f, 2f);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void CreateFloor() {
		Instantiate (floorwithgrass, new Vector2 (transform.position.x + 20.0f, -5.5f), transform.rotation);
	}

	void CreateMine() {
		float upMinePosition = Random.Range (3.0f, 1.0f);
		Vector2 upPosition = new Vector2(transform.position.x + mineDistance, upMinePosition);
		Vector2 downPosition = new Vector2(transform.position.x + mineDistance, upMinePosition - Random.Range (5, 1));

		Instantiate(mine, upPosition, transform.rotation);
		Instantiate(mine, downPosition, transform.rotation);
	}

	public static int GetMineDistance() {
		return mineDistance;
	}

}
