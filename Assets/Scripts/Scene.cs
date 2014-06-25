using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour {
	public GameObject mine;
	private static int mineDistance = 11;
	public GameObject sand;
	public GameObject background;
	public GameObject island;
	public GameObject tower;
	public GameObject ship;
	private bool spawn;
	private float bottomBorderOfUpperMine = 2f;

	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateMine", 0.1f, 2f);
		InvokeRepeating("CreateSand", 0.9f, 1.37f);
		InvokeRepeating("CreateBackground", 3f, 3f);
		Instantiate(island, new Vector2 (Random.Range (25f, 30f), 2.2f), transform.rotation);
		Instantiate(tower, new Vector2 (Random.Range (40f, 55f), 0.9f), transform.rotation);
		Instantiate(ship, new Vector2 (Random.Range (70f, 85f), -2.6f), transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void CreateMine() {
		float upperMinePosition = Random.Range (4f, bottomBorderOfUpperMine);
		Vector2 upPosition = new Vector2(transform.position.x + mineDistance, upperMinePosition);
		Vector2 downPosition = new Vector2(transform.position.x + mineDistance, upperMinePosition - Random.Range (5f, 1f));

		Instantiate(mine, upPosition, transform.rotation);
		Instantiate(mine, downPosition, transform.rotation);
	}

	void CreateSand() {
		Instantiate(sand, new Vector2 (35, -2), transform.rotation);
	}

	void CreateBackground() {
		Instantiate(background, new Vector2 (35, 1), transform.rotation);
	}

	public float GetBottomBorderOfUpperMine() {
		return bottomBorderOfUpperMine;
	}

}
