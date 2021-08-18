using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treasureMulti : MonoBehaviour
{

    [SerializeField] public GameObject padA;
    [SerializeField] public GameObject padB;
    

    private bool playerAOn;
    private bool playerBOn;

    

    //treasure
    [SerializeField] private GameObject treasure;

    // Start is called before the first frame update
    void Start()
    {
        
        playerAOn = false;
        playerBOn = true;

        

        padA = gameObject.transform.GetChild(0).gameObject;
        //padB = gameObject.transform.GetChild(1).gameObject;

        //padA.GetComponent<Collider>();

    }

    // Update is called once per frame
    void Update()
    {
        
        if (playerAOn == true && playerBOn==true)
        {
            Debug.Log(playerAOn);
            Debug.Log(playerBOn);

            Animator boxAnim = treasure.GetComponent<Animator>();
            boxAnim.SetBool("openbox", true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.GetComponentInChildren<Collider>().tag=="Player")
        {
            Debug.Log(playerAOn);
            playerAOn = true;
        }



    }
}
