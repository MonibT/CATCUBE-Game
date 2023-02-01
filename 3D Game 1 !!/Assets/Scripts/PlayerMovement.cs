using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 5.0f;


    void FixedUpdate()
    {

        rb.velocity = new Vector3(0, -5, 0);

        rb.velocity = new Vector3(0, 0, speed);
        

        if (Input.GetKey("d"))
        {
             rb.velocity = new Vector3(speed, 0, speed);
        }
        if (Input.GetKey("a"))
        {
            rb.velocity = new Vector3(-speed, 0, speed);
        }
        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        transform.rotation = Quaternion.identity;
    }



    

}
    
