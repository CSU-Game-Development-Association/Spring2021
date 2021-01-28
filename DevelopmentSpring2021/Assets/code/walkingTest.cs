using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class walkingTest : MonoBehaviour
{
    [SerializeField]
    Transform _destination;

    UnityEngine.AI.NavMeshAgent _navMeshAgent;

    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();

        //I'm following the tutorial closely for now, but even if anything else is changed, we should be sure to use debug messages.
        if(_navMeshAgent == null)
        {
            Debug.LogError("NavMeshAgent is missing!" + gameObject.name);
        }
    }


    private void LandHo()
    {

        if(_destination != null)
        {
            Vector3 targetvector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetvector);
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            LandHo();
        }
    }

}
