using UnityEngine;
using System.Collections;

public class SubmarineControl : MonoBehaviour {
	private float verticalSpeed = 13f;//0.1f;
	private bool endGame = false;
	private int score;
<<<<<<< HEAD
	public GameObject boom;
=======
	private int textSize = (int)(Screen.height / 30);
>>>>>>> origin/master

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKey (KeyCode.Mouse0) || Input.touchCount > 0) && !endGame) {
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
			if(coll.gameObject.name == "minev5(Clone)"){
				Instantiate(boom, new Vector2(coll.transform.position.x, coll.transform.position.y), transform.rotation);
				Destroy(coll.gameObject);

			}
		}
	}

	Rect centerRectangle ( Rect someRect) {
		someRect.x = ( Screen.width  - someRect.width ) / 2;
		someRect.y = ( Screen.height - someRect.height ) / 2;
		
		return someRect;
	}
	
	void OnGUI() {
		Rect windowRect = new Rect (200, 200, Screen.width / 5, Screen.height / 5);
		if (endGame) {
			if (PlayerPrefs.GetInt("highscore") < score)
				PlayerPrefs.SetInt("highscore", score);

			windowRect = GUI.Window (0, centerRectangle (windowRect), RestartGame, "<size="+textSize+">Game Over</size>");
			//gameObject.rigidbody2D.AddForce (new Vector2 (-15, 0));
		}

		GUI.Label(new Rect (Screen.width - (Screen.width * .12f),0, Screen.width / 2, Screen.height / 10), "<size="+textSize+">Your score: " + score + "</size>");
		GUI.Label(new Rect (25, 0, Screen.width / 2, Screen.height / 10), "<size="+textSize+">Highscore: " + PlayerPrefs.GetInt("highscore") + "</size>");
	}

	void RestartGame(int windowID) {
<<<<<<< HEAD
		GUI.Label (new Rect (25, 20, 100, 30), "Score: " + score);
		GUI.Label (new Rect (25, 40, 100, 30), "High score: " + PlayerPrefs.GetInt("highscore"));
		if (GUI.Button(new Rect(10, 60, 100, 30), "Start Again?"))
=======
		GUI.Label (new Rect (Screen.width / 15, Screen.height / 30, Screen.width / 2, 30), "<size="+textSize+">Score: " + score + "</size>");
		GUI.Label (new Rect (Screen.width / 20, Screen.height / 15, Screen.width / 2, 30), "<size="+textSize+">Highscore: " + PlayerPrefs.GetInt("highscore") + "</size>");
		if (GUI.Button(new Rect(Screen.width / 23, Screen.height / 9, Screen.width / 9, textSize * 2), "<size="+textSize+">Start Again?</size>"))
>>>>>>> origin/master
			Application.LoadLevel ("underwater"); 
		
	}

	public void AddScore() {
		if (!endGame)
			score++;
	}

	public bool isEndGame() {
		return endGame;
	}
}
