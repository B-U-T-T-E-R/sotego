using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject[] waypoints;
    private int currentWaypoint = 0;
    private float lastWaypointSwitchTime;
    public float speed;

    [SerializeField]
    public bool isDeadMob;

    void Start()
    {
        if(gameObject.CompareTag("Common"))
        {
            speed = 50;
        }

        if(gameObject.CompareTag("Heatly"))
        {
            speed = 35;
        }
        
        if(gameObject.CompareTag("Speedy"))
        {
            speed = 75;
        }

        lastWaypointSwitchTime = Time.time;
        isDeadMob = false;
    }

    void Update()
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