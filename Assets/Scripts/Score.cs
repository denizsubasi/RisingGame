
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform playerTransform;
    public Text scoreText;
    public int score = 0;
    public void IncreaseScore()
    {
        
        score++;
        scoreText.text = score.ToString();
   
    }


}
