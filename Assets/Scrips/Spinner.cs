using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float x_spin = 0.0f;
    [SerializeField] float y_spin = 1.0f;
    [SerializeField] float z_spin = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(x_spin, y_spin, z_spin);
    }
}
