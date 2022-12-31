using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float speed;
    Vector3 accVector;


    // Start is called before the first frame update
    void Start()
    {
        accVector = new Vector2(2f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) {
            myRigidbody.velocity = Vector2.right * speed;

            if (myRigidbody.velocity.x < 25)
            {
                myRigidbody.velocity *= Vector2.right * accVector;
            }

        }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            myRigidbody.velocity = Vector2.left * speed;

        }

        if (Input.GetKey(KeyCode.Space))
        {
            myRigidbody.velocity = Vector2.up * speed;   
        }

    }
}
