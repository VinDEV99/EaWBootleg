using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshMovement : MonoBehaviour
{
    private NavMeshAgent navmeshagent;
    
    // Start is called before the first frame update
    void Start()
    {
        navmeshagent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(navmeshagent.destination, transform.position);
        
        if (distance > 0.1)
        {
            Vector3 movement = transform.forward * Time.deltaTime;

            navmeshagent.Move(movement);
        }
        
    }
}
