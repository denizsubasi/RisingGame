
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public Player player;
    float restartDelay = 2f;
    public GameObject completeLevelUI;

    public void EndGame()
    {
        Debug.Log("End Game");
        player.enabled = false;
        completeLevelUI.SetActive(true);
        Invoke("Restart", restartDelay);
        FindObjectOfType<EndScore>().EndScoreText(FindObjectOfType<Score>().score);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}

