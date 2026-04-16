using UnityEngine;
using UnityEngine.AI;
public class AgentSimpleController : MonoBehaviour
{
    public Transform Target;
    private NavMeshAgent agent;

    Transform player;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        GetComponent<CapsuleCollider>();

    }

    // Update is called once per frame
    void Update()
    {
        if (agent != null)
        {
            agent.SetDestination(Target.position);
        }
    }

   
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        if (player != null)
        {
            Gizmos.color = Color.red;

            Vector3 dir = player.position - transform.position;
            Gizmos.DrawRay(transform.position, dir);
        }
    }
}
