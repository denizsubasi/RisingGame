
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Player player;

    public void EndGame()
    {
        Debug.Log("End Game");
        player.enabled = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);   
    }

}

