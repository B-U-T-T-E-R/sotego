using UnityEngine;

public class HeatlyMobController : EnemyController
{
    [SerializeField]
    private float speed;
    [HideInInspector]
    private GameObject[] waypoints;

    void Start()
    {
        waypoints = GetComponent<WaypointsManager>().waypoints;
    }

    void Update()
    {
        Move(speed, waypoints);
    }
}
