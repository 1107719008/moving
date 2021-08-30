using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockVelocity : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject TheRock;

    private float time = 0.0f;
    private bool isMoving = false;
    private bool isPressed = false;


    void Start()
    {
        rb = TheRock.GetComponent<Rigidbody>();
    }

    void Update()
    {
        //isPressed = Input.GetButtonDown("Jump");
    }

    void FixedUpdate()
    {
        if (isPressed==true&&isMoving==true)
        {
            
            rb.velocity = new Vector3(0, 0, 10);
            
        }

        if (isMoving)
        {
            time = time + Time.fixedDeltaTime;
            if (time > 10.0f)
            {
                Debug.Log(gameObject.transform.position.y + " : " + time);
                time = 0.0f;
                
            }
            isMoving = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isPressed = true;
            isMoving = true;

        }
    }
}
