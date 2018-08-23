
using UnityEngine;

public class players : MonoBehaviour {

    public float yukselmegucu = 10f;
    public Rigidbody2D rb;
    
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0) )
        {
            rb.velocity = Vector2.up * yukselmegucu;
        }
	}
}
