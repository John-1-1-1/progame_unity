using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover: MonoBehaviour
{
    public float Speed;
    private Rigidbody _rb;

    // Start is called before the first frame update
    void Start(){
        _rb = GetComponent<Rigidbody>();   
    }
    // Update is called once per frame
    void Update(){
        MovementLogic();
    }

     private void MovementLogic()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        _rb.AddForce(movement * Speed);
    }
     
} 
