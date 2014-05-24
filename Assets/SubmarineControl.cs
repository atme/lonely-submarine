using UnityEngine;
using System.Collections;

public class SubmarineControl : MonoBehaviour {
	private int horizontalSpeed = 1;
	private int verticalSpeedMax = 30;
	private int verticalSpeedNormal = 0;
	private bool endGame = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0) && !endGame)
			constantForce.force = new Vector2(horizontalSpeed, verticalSpeedMax);
		
		if (Input.GetKeyUp (KeyCode.Mouse0))
			constantForce.force = new Vector2(horizontalSpeed, -verticalSpeedMax);
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Finish"){
			endGame = true;
		}
	}

	Rect centerRectangle ( Rect someRect) {
		someRect.x = ( Screen.width  - someRect.width ) / 2;
		someRect.y = ( Screen.height - someRect.height ) / 2;
		
		return someRect;
	}
	
	void OnGUI() {
		Rect windowRect = new Rect(200, 200, 120, 60);
		if (endGame)
			windowRect = GUI.Window(0, centerRectangle(windowRect), RestartGame, "End Game");
	}

	void RestartGame(int windowID) {
		if (GUI.Button(new Rect(10, 20, 100, 30), "Start Again?"))
			Application.LoadLevel ("underwater"); 
		
	}
}
