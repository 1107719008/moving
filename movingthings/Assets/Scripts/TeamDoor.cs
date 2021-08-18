using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamDoor : MonoBehaviour
{


    private bool IsRedTeam;
    public GameObject theDoor;

    void Start()
    {

        
        IsRedTeam = false;
    }

    
    void Update()
    {
        if (IsRedTeam==true)
        {
            Debug.Log(IsRedTeam);
            theDoor.GetComponent<BoxCollider>().enabled = false;

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "playerRed")//the name of the player(different team)
        {
            IsRedTeam= true;
        }
    }
}
