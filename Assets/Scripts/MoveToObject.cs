using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class MoveToObject : MonoBehaviour
{
    // Start is called before the first frame update
	public Transform Target;
	private NavMeshAgent _agent;
	
    void Start()
    {
     _agent = GetComponent<NavMeshAgent>();   
    }

    // Update is called once per frame
    void Update()
    {
        _agent.destination = Target.position;
    }
}
