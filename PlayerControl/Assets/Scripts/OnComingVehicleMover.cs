using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnComingVehicleMover : MonoBehaviour
{
    public float speed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //the vehicle will be moving forever here//
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
