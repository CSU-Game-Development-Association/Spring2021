using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    Transform activeChar;
    Vector3 cameraDeform;
    
    
    
    void Start()
    {
        
        
    }


    void Update() //I want to add more and better features to the camera later eg. if the player can select different characters to control from bird's eye
    {
        
    }

    void LateUpdate()
    {
        cameraDeform = transform.forward;

        if(Input.GetMouseButton(0))
        {
            transform.RotateAround(activeChar.position, transform.right, Input.GetAxis("Mouse Y") * 2);
            transform.RotateAround(activeChar.position, activeChar.up, Input.GetAxis("Mouse X") * 2);

        }
        if(activeChar.hasChanged)
        {
            transform.position = activeChar.position - (cameraDeform * 10);
            activeChar.hasChanged = false;
        }
    }
}
