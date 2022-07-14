using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField]float time_to_drop = 10.0f;
    MeshRenderer renderer;
    Rigidbody rigid_body;

    // Start is called before the first frame update
    void Start()
    {   
        renderer = GetComponent<MeshRenderer>();
        rigid_body = GetComponent<Rigidbody>();

        renderer.enabled = false; 
        rigid_body.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > time_to_drop){
            renderer.enabled = true;
            rigid_body.useGravity = true;
            //Debug.Log(Time.time);
        }
    }
}
