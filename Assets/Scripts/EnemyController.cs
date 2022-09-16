using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private int currentWaypoint = 0;
    private float lastWaypointSwitchTime;

    public void Move(float speed, GameObject[] waypoints)
    {
        Vector3 startPosition = waypoints [currentWaypoint].transform.position;
        Vector3 endPosition = waypoints [currentWaypoint + 1].transform.position;
        float pathLength = Vector3.Distance (startPosition, endPosition);
        float totalTimeForPath = pathLength / speed;
        float currentTimeOnPath = Time.time - lastWaypointSwitchTime;
        gameObject.transform.position = Vector2.Lerp (startPosition, endPosition, currentTimeOnPath / totalTimeForPath);
        if (gameObject.transform.position.Equals(endPosition)) 
        {
            if (currentWaypoint < waypoints.Length - 2)
            {
                currentWaypoint++;
                lastWaypointSwitchTime = Time.time;
            }     
            else
            {
                Destroy(gameObject);
            }
        }
    }
}