using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour {
	public GameObject mine;
	public GameObject[] sands;
	public GameObject[] backgrounds;
	public GameObject[] locations;
	public GameObject sky;
	private bool spawn;
	private bool ready = true;
	private bool backgroundReady = true;
	private bool locationReady = true;
	private bool skyReady = true;
	private SubmarineControl submarine;

	// Use this for initialization
	void Start () {
		submarine = GameObject.Find ("submarine").GetComponent<SubmarineControl>();
	}

	// Update is called once per frame
	void Update() {

	}
}
