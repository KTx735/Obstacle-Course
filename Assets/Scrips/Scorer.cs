using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{  
    int hits = -1;
    //Every time we collide with an object, The hit counters is incremented
    private void OnCollisionEnter(Collision other) 
    {
        //If we have a tag that is not it then increment score
        if(other.gameObject.tag != "Hit"){
            hits++;
            Debug.Log("Hit Counter: " + hits);
        }
    }

}
