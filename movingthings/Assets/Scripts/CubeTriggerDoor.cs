using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTriggerDoor : MonoBehaviour
{

    [SerializeField]
    public GameObject Door;
    public float maxOpen = 5f;  //max door height
    public float maxClose = 0f;
    public float doorSpeed = 5f;

    bool CubeOnPad;
    
    void Start()
    {
        CubeOnPad = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CubeOnPad)
        {
            if (Door.transform.position.y < maxOpen)//move LeftRight
            {
                //Debug.Log(playerHere);
                Door.transform.Translate(0f, doorSpeed * Time.deltaTime, 0f);
            }
        }
        else
        {
            if (Door.transform.position.y > maxClose)
            {
                //Debug.Log(playerHere);
                Door.transform.Translate(0f, -doorSpeed * Time.deltaTime, 0f);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "TheCube")
        {
            CubeOnPad = true;
        }
        
    }

}
