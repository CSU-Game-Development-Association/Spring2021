using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
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
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 5f, 0f, 0f);
        transform.Translate(0f, 0f, Input.GetAxis("Vertical") * Time.deltaTime * 5f);

        if (Input.GetButtonDown("Jump") && onGround)
        {
            onGround = false;
            cube.AddForce(new Vector3(1, 5, 0), ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        onGround = true ;
    }
}
