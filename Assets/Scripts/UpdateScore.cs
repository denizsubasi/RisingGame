
using UnityEngine;

public class UpdateScore : MonoBehaviour {

    void OnTriggerEnter2D()
    {
      
        FindObjectOfType<Score>().IncreaseScore();
    }
}

