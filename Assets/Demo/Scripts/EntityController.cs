using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EntityController : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private NavMeshAgent _agent;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Get mouse position in World space.
            var ray = _camera.ScreenPointToRay(Input.mousePosition);

            // Raycast to the world
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                _agent.SetDestination(hit.point);
            }
        }
    }
}
