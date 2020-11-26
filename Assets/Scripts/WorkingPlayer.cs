using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class WorkingPlayer : NetworkBehaviour
{

// var SpawnPoint : Transform;
//var respawn : boolean = false;
//var Player: int;

public Rigidbody rb;
public KeyCode left;
public KeyCode right;
public KeyCode forward;
public KeyCode back;
private Vector3 moveDirection;
public int speed;


//public float speed = 0;
//private Rigidbody rb;
private float movementX;
private float movementY;


    // Start is called before the first frame update
    
     void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void HandleMovement()
    {
      if (Input.GetKey(left)){
      rb.MovePosition(transform.position + Vector3.left * speed);
      }
      
      if (Input.GetKey(back))
      {
      rb.MovePosition(transform.position + Vector3.back * speed);
      }
      
      if (Input.GetKey(forward))
      {
      rb.MovePosition(transform.position + Vector3.forward * speed);
      }
      
      if (Input.GetKey(right))
      {
      rb.MovePosition(transform.position + Vector3.right * speed);
      }
      
    Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);

  //  private void OnMove(InputValue movementValue)
//    {
  //      Vector2 movementVector = movementValue.Get<Vector2>();

    //    movementX = movementVector.x;
      //  movementY = movementVector.y;
//    }

 //   void FixedUpdate()
//    {
 //       Vector3 movement = new Vector3(movementX, 0.0f, movementY);
//
//        rb.AddForce(movement * speed);
//    }

// }
      
    }


void GetDamage(){

}

    // Update is called once per frame
    void Update()
    {
      HandleMovement();
      GetDamage();
    }








}
    
       //function Update(){
 
    //if(Player<= 0)
    //{
    //respawn = true;
    //}
    //else
    //{
    //respawn = false;
    //}
 
     //if(respawn)
     //{
 
    //transform.position = SpawnPoint.transform.position;
 
     //}
// }


    // Start is called before the first frame update