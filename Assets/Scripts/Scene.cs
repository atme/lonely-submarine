using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour {
	public GameObject mine;
	private static int mineDistance = 11;
	public GameObject[] sands;
	public GameObject[] backgrounds;
	public GameObject[] locations;
	public GameObject sky;
	private bool spawn;
	private float bottomBorderOfUpperMine = 2f;
	private bool readynow = true;
	private bool readynowforbackground = true;
	private bool readynowforlocation = true;
	private bool readynowforsky = true;

	// Use this for initialization
	void Start () {
		Instantiate(sands[Random.Range(0,3)], new Vector2 (6.7f, -2.2f), transform.rotation);
		Instantiate(sands[Random.Range(0,3)], new Vector2 (27.0f, -2.2f), transform.rotation);
		Instantiate(backgrounds[Random.Range(0,3)], new Vector2 (6.7f, -1.7f), transform.rotation);
		Instantiate(backgrounds[Random.Range(0,3)], new Vector2 (27.0f, -1.7f), transform.rotation);
		Instantiate(sky, new Vector2 (9f, 4.98f), transform.rotation);
		InvokeRepeating("CreateMine", 0.1f, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		{
			if (readynow)
				StartCoroutine(MakeFloor());
		}
		{
			if (readynowforbackground)
				StartCoroutine(MakeBackground());
		}
		{
			if (readynowforlocation)
				StartCoroutine(MakeLocation());
		}
		{
			if (readynowforsky)
				StartCoroutine(MakeSky());
		}

	}

	void CreateMine() {
		float upperMinePosition = Random.Range (4f, bottomBorderOfUpperMine);
		Vector2 upPosition = new Vector2(transform.position.x + mineDistance, upperMinePosition);
		Vector2 downPosition = new Vector2(transform.position.x + mineDistance, upperMinePosition - Random.Range (5f, 1f));

		Instantiate(mine, upPosition, transform.rotation);
		Instantiate(mine, downPosition, transform.rotation);
	}

	private IEnumerator MakeFloor() {
		readynow = false;
		Instantiate(sands[Random.Range(0,3)], new Vector2 (47.0f, -2.2f), transform.rotation);
		yield return new WaitForSeconds(1.3f);
		readynow = true;
	}

	private IEnumerator MakeBackground() {
		readynowforbackground = false;
		Instantiate(backgrounds[Random.Range(0,4)], new Vector2 (47.0f, -1.7f), transform.rotation);
		yield return new WaitForSeconds(2);
		readynowforbackground = true;
	}

	private IEnumerator MakeLocation() {
		readynowforlocation = false;
		Instantiate(locations[0], new Vector2 (25.0f, 2.4f), transform.rotation);
		yield return new WaitForSeconds(Random.Range(30,40));
		Instantiate(locations[1], new Vector2 (25.0f, 1.15f), transform.rotation);
		yield return new WaitForSeconds(Random.Range(30,40));
		Instantiate(locations[2], new Vector2 (25.0f, -2.6f), transform.rotation);
		yield return new WaitForSeconds(Random.Range(30,40));
		Instantiate(locations[3], new Vector2 (25.0f, 3.04f), transform.rotation);
		yield return new WaitForSeconds(Random.Range(30,40));
		Instantiate(locations[4], new Vector2 (30.0f, 0f), transform.rotation);
		yield return new WaitForSeconds(Random.Range(30,40));
	}

	private IEnumerator MakeSky() {
		readynowforsky = false;
		yield return new WaitForSeconds(39);
		Instantiate(sky, new Vector2 (31.0f, 4.98f), transform.rotation);
		yield return new WaitForSeconds(150);
		readynowforsky = true;
	}

	public float GetBottomBorderOfUpperMine() {
		return bottomBorderOfUpperMine;
	}

}
