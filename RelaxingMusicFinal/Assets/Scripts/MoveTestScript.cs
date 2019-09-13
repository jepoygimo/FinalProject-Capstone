using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MoveTestScript : MonoBehaviour
{
    public float speed = 0.8f;
    float loc;
    Button a;
 
    // Start is called before the first frame update
    void Start()
    {
        loc = gameObject.transform.position.y;
        a = gameObject.GetComponent<Button>();
                 
    }

    private void Update()
    {

    }

    void moveBTN()
    {

        gameObject.transform.Translate(0, speed, 0);
        if (gameObject.transform.position.y >= loc + 5 || gameObject.transform.position.y <= loc - 5)
        {
            speed = -speed;
        }
    }


}
