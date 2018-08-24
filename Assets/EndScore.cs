
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour {

    public Text scoreText;
	public void EndScoreText(int score) {
        scoreText.text = "Score: " + score;
    }
}
