
using UnityEngine;

public class movingbox : MonoBehaviour {
    public float hiz = 100f;
    float a = 0.1f;
    public int leftOrRight;

    void Start(){
      // leftOrRight= getRandomNuber();
    }
    void Update () {

        transform.position =new Vector3(transform.position.x+a,0,0);
        if ((int)transform.position.x == 3) { a = -0.1f;
            Debug.Log("şuan 3 de");
        }
        if ((int)transform.position.x == -3)
        {
            a = 0.1f;
            Debug.Log("şuan -3 de");

        }

        /*
                if (leftOrRight == 1)
                {
                    saghareket();
                }
                else
                {
                    solahareket();
                }

                Vector3 defaultVector = new Vector3(-3f, 0f, 0f);
                Vector3 defaultVector2 = new Vector3(3f, 0f, 0f);
                if (transform.position==defaultVector)
                {
                    saghareket();
                }
               else if (transform.position==defaultVector2)
                {
                    solahareket();
                }
            }

            int getRandomNuber()
            {
                return Random.Range(0, 1);
            }
            void saghareket()
            {
                Vector3 defaultVector = transform.position;
                Vector3 defaultVector2 = new Vector3(0.2f, 0f, 0f);
                transform.position = defaultVector + defaultVector2;
                */
    }
    void solahareket()
    {
        Vector3 defaultVector = transform.position;
        Vector3 defaultVector2 = new Vector3(0.2f, 0f, 0f);
        transform.position = defaultVector - defaultVector2;
    }
}

