using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Move : MonoBehaviour
{
    public float rotatespeed;
    private float movex;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movex = Input.GetAxis("Mouse X");
        if (Input.GetMouseButton(0))
        {
            transform.Rotate(0f, movex * rotatespeed * Time.deltaTime, 0f);
        }
    }
}
