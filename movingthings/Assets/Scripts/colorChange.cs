using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{

    

    public GameObject ObBeChanged;
    public Color changingColor;
    private bool playerTouched;

    void Start()
    {
        playerTouched = false;
        
    }
    
    void Update()
    {
        if (playerTouched==true)
        {

            var cubeRenderer = ObBeChanged.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", changingColor);

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
            playerTouched = true;
        }

    }
}
