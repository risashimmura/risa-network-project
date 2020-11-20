using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

var SpawnPoint : Transform;
var respawn : boolean = false;
var Player: int;

public class Player: NetworkBehaviour
{
    void HandleMovement(){
        if (isLocalPlayer){
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal * 0.1f, moveVertical * 0.1f, 0);
            transform.position = transform.position + movement;

        }
    }
    void Update(){
        HandleMovement();
    }
   
   function Update(){
 
    if(Player<= 0)
    {
    respawn = true;
    }
    //else
    //{
    //respawn = false;
    //}
 
     if(respawn)
     {
 
     transform.position = SpawnPoint.transform.position;
 
     }
 }
}
<<<<<<< Updated upstream:Assets/Scripts/Player.cs

=======
 
 
>>>>>>> Stashed changes:Assets/New Folder/Player.cs
