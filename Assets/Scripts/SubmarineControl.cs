using UnityEngine;
using System.Collections;

public class SubmarineControl : MonoBehaviour {
	private float verticalSpeed = 13f;//0.1f;
	public bool endGame = false;
	private int score;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Mouse0) && !endGame) {
			//transform.position = new Vector2 (transform.position.x, transform.position.y + verticalSpeed);
			rigidbody2D.AddForce (new Vector2(0, verticalSpeed));
		} else {
			//transform.position = new Vector2 (transform.position.x, transform.position.y - verticalSpeed);
			rigidbody2D.AddForce (new Vector2(0, -verticalSpeed));
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Finish"){
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
			windowRect = GUI.Window(0, centerRectangle(windowRect), RestartGame, "Score:" + score);
		GUI.Label(new Rect (Screen.width - 100,0,100,50), "<color='black'>Your score: " + score + "</color>");
	}

	void RestartGame(int windowID) {
		if (GUI.Button(new Rect(10, 20, 100, 30), "Start Again?"))
			Application.LoadLevel ("underwater"); 
		
	}

	public void AddScore() {
		if (!endGame)
			score++;
	}
}
