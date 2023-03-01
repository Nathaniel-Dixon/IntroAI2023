using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class ClickToMove : MonoBehaviour
{
NavMeshAgent _agent;
RaycastHit _hitInfo = new RaycastHit();
    // Start is called before the first frame update
    void Start()
    {
       _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
   // RaycastHit _hitInfo = new RaycastHit();
        if(Input.GetMouseButtonDown(0))
        {
        RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
             _agent.destination = hitInfo.point;
            }
            else
            {
                _agent.destination = transform.position;
            }
        }
    }
}
