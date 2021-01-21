using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    Rigidbody cube;
    bool onGround;
    // Start is called before the first frame update
    void Start()
    {
        cube = GetComponent<Rigidbody>();
        onGround = true;
    }

    // Update is called once per frame
    void Update()
    {
        processInput();
        if (Input.GetButtonDown("Jump") && onGround)
        {
            onGround = false;
            cube.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }

    private void processInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cube.AddForce(new Vector3(0, 0, 1), ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            cube.AddForce(new Vector3(0, 0, -1), ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            cube.AddForce(new Vector3(-1, 0, 0), ForceMode.Force);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            cube.AddForce(new Vector3(1, 0, 0), ForceMode.Force);
        }

    }
}
