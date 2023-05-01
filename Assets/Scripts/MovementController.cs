using UnityEngine;
using UnityEngine.AI;

public class MovementController : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;
    private Vector3 _destination;

    private void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // Перемещаем персонажа в направлении _destination.
        _navMeshAgent.SetDestination(_destination);

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       // RaycastHit hit;
        if (Physics.Raycast(ray, out var hit,100f))
        {
            if (Input.GetMouseButtonDown(0))
            {
                var hitPoint = hit.point;
                _destination = hitPoint;
            }
        }
        // TODO: Получите точку, по которой кликнули мышью и задайте ее вектор в поле _destination.
    }
}