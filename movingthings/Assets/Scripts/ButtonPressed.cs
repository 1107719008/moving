using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressed : MonoBehaviour
{

    private bool IsPressed;
    // Start is called before the first frame update
    void Start()
    {
        IsPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPressed == true)
        {
            this.transform.Translate(0.0f, -0.1f*Time.deltaTime, 0.0f);
            IsPressed = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        IsPressed = true;
    }
}
