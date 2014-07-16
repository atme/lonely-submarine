using UnityEngine;
using System.Collections;

public class SubmarineControl : MonoBehaviour {
	private float verticalSpeed = 13f;//0.1f;
	private bool endGame = false;
	private int score = 0;
	public GameObject boom;
	private int textSize = (int)(Screen.height / 30);
	public GameObject boomsub;
	private bool boomsubbool;
	public GameObject pipe;
	public GameObject boomsubex;
	public GameObject restart;
	public GameObject _score;
	public GameObject highscore;
	public AudioClip explosion;

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
		if (coll.gameObject.tag == "Finish" && endGame == false){
			endGame = true;
			if(coll.gameObject.name == "minev5(Clone)"){
				AudioSource.PlayClipAtPoint(explosion, transform.position);
				boomsubmarine();
				Instantiate(boom, new Vector2(coll.transform.position.x, coll.transform.position.y), transform.rotation);
				Destroy(coll.gameObject);
			}
			_score.guiText.text = "Score: " + getScore();
			if (PlayerPrefs.GetInt("highscore") < getScore()) {
				PlayerPrefs.SetInt("highscore", getScore());
				highscore.guiText.text = "<b><color=brown>NEW!</color></b> Highscore: " + getScore();
			} else {
				highscore.guiText.text = "Highscore: " + PlayerPrefs.GetInt("highscore");
			}
			Instantiate(_score, new Vector2 (0.5f, 0.8f), transform.rotation);
			Instantiate(highscore, new Vector2 (0.5f, 0.6f), transform.rotation);
			Instantiate(restart, new Vector2 (0.5f, 0.5f), transform.rotation);
		}
	}

	Rect centerRectangle ( Rect someRect) {
		someRect.x = ( Screen.width  - someRect.width ) / 2;
		someRect.y = ( Screen.height - someRect.height ) / 2;
		
		return someRect;
	}
	
	void OnGUI() {
		GUI.Label(new Rect (Screen.width - (Screen.width * .15f),0, Screen.width / 2, Screen.height / 10), "<size="+textSize+">Your score: " + getScore() + "</size>");
		GUI.Label(new Rect (25, 0, Screen.width / 2, Screen.height / 10), "<size="+textSize+">Highscore: " + PlayerPrefs.GetInt("highscore") + "</size>");
	}

	void boomsubmarine(){
		if (!boomsubbool) {
				gameObject.GetComponent<PolygonCollider2D>().isTrigger = true;
				Instantiate (boomsub, new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y), transform.rotation);
				Instantiate(boomsubex, new Vector2 (gameObject.transform.position.x, gameObject.transform.position.y), transform.rotation);
				gameObject.renderer.enabled = false;
				boomsubbool = true;
		}
	}

	public void AddScore() {
		if (!endGame)
			score++;
	}

	public bool isEndGame() {
		return endGame;
	}

	private int getScore() {
		return score / 2;
	}

}
