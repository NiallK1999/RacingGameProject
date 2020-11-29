using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovment : MonoBehaviour
{
    // stored as private 
    public float speed = 5.0f;
    public float turnSpeed =25f;
    public float horizontalInput;
    public float ForwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // this is where we get palyer input 
        horizontalInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");
        //move the vehicle forwards
        transform.Translate(Vector3.forward * Time.deltaTime * speed * ForwardInput);
        //we turn the veical 
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
        
       
    }
}
