using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour
{
    float speed = -2f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0, 0, speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "floor")
        {
            return;
        }

        Debug.Log("I hit something"); 

        if (speed < 0)
        {
            speed = speed + speed * speed;
        }
        else if (speed > 0)
        {
            speed = speed + -speed + -speed;
        }
        
    }
}
