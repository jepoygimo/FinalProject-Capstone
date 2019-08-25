using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTestScript : MonoBehaviour
{
    float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        gameObject.transform.Translate(0, speed, 0);
        if (gameObject.transform.position.z >= 5 || gameObject.transform.position.z <= -5)
        {
            speed = -speed;
        }
    }


}
