using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Time.deltaTime * 5;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * 5;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down / 10);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up / 10);
        }
    }
}