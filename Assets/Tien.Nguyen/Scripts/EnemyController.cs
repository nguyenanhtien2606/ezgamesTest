using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] Transform[] wayPoints;
    [SerializeField] float moveSpeed;

    int currentWaypointIndex;
    float distance;

    private void Start()
    {
        currentWaypointIndex = 0;
        transform.LookAt(wayPoints[currentWaypointIndex].position);
    }

    private void Update()
    {
        distance = Vector3.Distance(transform.position, wayPoints[currentWaypointIndex].position);
        if (distance < 1f)
        {
            ChangeWayPoint();
        }
        MoveNextWayPoint();
    }

    void MoveNextWayPoint()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    void ChangeWayPoint()
    {
        currentWaypointIndex++;
        if (currentWaypointIndex >= wayPoints.Length)
        {
            currentWaypointIndex = 0;
        }
        transform.LookAt(wayPoints[currentWaypointIndex].position);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.EndGame(false);
        }
    }
}
