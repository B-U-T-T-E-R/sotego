using UnityEngine;
public class EnemyController : MonoBehaviour
{
    private int currentwayPoints = 0;
    private float lastWaypointSwitchTime;
    public Transform[] wayPoints;

    public void Moving(float mspeed)
    {
        Vector3 startPosition = wayPoints [currentwayPoints].transform.position;
        Vector3 endPosition = wayPoints [currentwayPoints + 1].transform.position;

        float pathLength = Vector3.Distance (startPosition, endPosition);
        float totalTimeForPath = pathLength / mspeed;
        float currentTimeOnPath = Time.time - lastWaypointSwitchTime;
        gameObject.transform.position = Vector2.Lerp(startPosition, endPosition, currentTimeOnPath / totalTimeForPath);

        if(gameObject.transform.position.Equals(endPosition))
        {
            if(currentwayPoints < wayPoints.Length - 2)
            {
                currentwayPoints++;
                lastWaypointSwitchTime = Time.time;
            }
            else
            {        
                Die();
            }
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}