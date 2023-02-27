using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
         

    }

    // Update is called once per frame
    void Update()
    {      //where we get the player inpput//
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //gonna move the vehicle forward//
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
       //we turn the vehicle here//
        transform.Rotate(Vector2.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
