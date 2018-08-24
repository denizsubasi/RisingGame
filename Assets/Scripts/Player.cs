
using UnityEngine;

public class Player : MonoBehaviour {

    public float yukselmegucu = 10f;
    public Rigidbody2D rb;
    
    
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0) )
        {
            rb.velocity = Vector2.up * yukselmegucu;
        }
	}
}
