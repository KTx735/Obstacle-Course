using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //[SerializeField]float x_value = 0.01f;
    //float y_value = 0f;
    //float z_value = 0f;
    [SerializeField] float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(1, 0, 0);
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("----Instructions----");
        Debug.Log("The player mosves with ASDW or arrows");
        Debug.Log("Do not hit the walls");
        Debug.Log("Get to the finish line");
        Debug.Log("Enjoy!");
    }

    void MovePlayer()
    {
        float user_horizontal_input = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float user_vertical_input = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(user_horizontal_input, 0, user_vertical_input);
    }

}
