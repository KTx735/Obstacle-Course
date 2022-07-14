using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //Only when we enter a collision
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player"){
        //Display everytime the player touches a wall.
        //Debug.Log("Bumped into a wall");   
        GetComponent<MeshRenderer>().material.color = Color.red;
        gameObject.tag = "Hit";
        }

    }

}
