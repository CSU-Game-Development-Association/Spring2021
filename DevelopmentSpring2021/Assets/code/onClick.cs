using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class onClick : MonoBehaviour
{

    RaycastHit hit;
    public Vector3 attentionPoint;
    
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {

                attentionPoint = hit.point;
                transform.position = attentionPoint;
            }
        }
        
    }
}
