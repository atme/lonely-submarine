using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour
{
	void OnMouseDown() {
		Application.LoadLevel ("underwater"); 
	}
	
	void onTouchStart() {
		Application.LoadLevel ("underwater"); 
	}
}

