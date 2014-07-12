using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour
{
	RaycastHit hit;
	Ray MyRay;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

	void OnMouseDown() {
		Application.LoadLevel ("underwater"); 
	}
	
	void onTouchStart() {
		Application.LoadLevel ("underwater"); 
	}
}

