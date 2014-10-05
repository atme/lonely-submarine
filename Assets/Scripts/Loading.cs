using UnityEngine;
using System.Collections;

public class Loading : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(Load());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	IEnumerator Load() {
		yield return new WaitForSeconds(5);
		Application.LoadLevel(1);
	}
}
