using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//change scene
public class LevelManager : MonoBehaviour {

	//timer countdown
	public Text timerText;
	private float secondsCount = 59f;
	private int minuteCount = 1;

	public void LoadScene (string name){
        SceneManager.LoadScene(name); 
	}
	public void QuitRequest (){
		Application.Quit();
	}

	void Update () {
//		Camera.main.transform.position = Vector3.Lerp (Camera.main.transform.position.x,Camera.main.transform.position.y, 0);

		// if (screenPos.x < 0) {
		//	print ("Can't escape work!");

		//} else if (screenPos.x > Screen.width) {
		//	print ("No.");
		Scene tmp = SceneManager.GetActiveScene ();
		if (tmp.name == "Puzzle1") {
			UpdateUI ();
		}
	}
			
	void OnCollisionStay2D (Collision2D collider) {
		if (collider.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space)) {
				SceneManager.LoadScene("Win");
		}
	}
	
	public void UpdateUI () {
		secondsCount -= Time.deltaTime;
		if (secondsCount >= 60) {
			minuteCount--;
			secondsCount = 30f;
		} else if (minuteCount >= 60) {
			minuteCount = 1;
		} else if (secondsCount <= 0) {
			Application.LoadLevel ("Lose");
		}

		timerText.text = string.Format (
			"{0:0}:{1:00}", 
			Mathf.Round (secondsCount / 120), 
			secondsCount % 60);
	}
}