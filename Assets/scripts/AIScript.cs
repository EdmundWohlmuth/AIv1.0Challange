using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour
{
    public float speed = -2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0, 0, speed * Time.deltaTime);

        // jumping
        Random.Range(1, 20);

    }

    private void OnCollisionEnter(Collision collision) // collision detection
    {
        if (collision.gameObject.tag == "floor") // ignore floor collision
        {
            return;
        }

        Debug.Log("I hit something"); 

        if (speed < 0) // on colliding anything that isn't the floor
        {
            speed = speed *-1;
        }
        else if (speed > 0)
        {
            speed = speed *-1;
        }       
    }

    private void OnTriggerEnter(Collider other) // 'GoombaStomping' the NotAGoomba
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Get stomped, you rube");
            speed = 0f;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
}
