using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]

    public GameObject Door;

    public float maxOpen = 5f;//max door height
    public float maxClose = 0f;
    public float doorSpeed = 5f;

    bool playerHere;
   

    

    private void Start()
    {
        playerHere = false;
        

    }
    private void Update()
    {
        if (playerHere)
        {
            if (Door.transform.position.y < maxOpen)//move LeftRight
            {
                //Debug.Log(playerHere);
                Door.transform.Translate( 0f, doorSpeed * Time.deltaTime, 0f);
            }
        }
        else
        {
            if (Door.transform.position.y > maxClose)
            {
                //Debug.Log(playerHere);
                Door.transform.Translate( 0f, -doorSpeed * Time.deltaTime, 0f);
            }
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerHere = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerHere = false;
        }
    }
   


}
