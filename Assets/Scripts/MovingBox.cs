
using UnityEngine;

public class MovingBox: MonoBehaviour {
    public float hiz = 100f;
    float speed = 0.05f;
    public bool leftOrRight;
    bool firstPositionEnded = false;
    public bool endGame=false;
    void Start(){
       leftOrRight= getRandomDirection();
    }
    void Update () {

        if (endGame==false) {
        if (!firstPositionEnded)
        {
            transform.position = new Vector3(leftOrRight ? transform.position.x + speed : transform.position.x - speed,
      transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x + speed,
      transform.position.y, transform.position.z);
        }

        if ((int)transform.position.x == 3) {
            speed = -0.05f;
            Debug.Log("x == 3");
            firstPositionEnded = true;
        }
        if ((int)transform.position.x == -3){
            speed = 0.05f;
            Debug.Log("x == --3");
            firstPositionEnded = true;
        }
        }
        
    }
   
    bool getRandomDirection()
    {
        int randomNumber = Random.Range(0, 2);

        if (randomNumber == 0){
            Debug.Log("Random False");
            return false;
        
        }
        else if (randomNumber ==1)
        {
            Debug.Log("Random True");
            return true;
        }

        return false;
    }

}

