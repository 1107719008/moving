using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObj : MonoBehaviour
{

    bool playerHere;
    // Start is called before the first frame update
    void Start()
    {
        playerHere = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHere)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.left * 100.0f);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "TheCube")
        {
            playerHere = true;
        }

    }
}
