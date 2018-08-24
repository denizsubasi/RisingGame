
using UnityEngine;

public class BoxTrigger : MonoBehaviour {

    public Rigidbody2D  playerRB; 

    void OnCollisionEnter2D(Collision2D collisionInfo)
        {
        if (collisionInfo.collider.tag == "box")
        {
            playerRB.bodyType = RigidbodyType2D.Static;
            FindObjectOfType<GameManager>().EndGame();
        }
    
    }
}
