using UnityEngine;

public class HeatlyMobController : EnemyController
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float health = 75;
    [HideInInspector]
    private GameObject[] waypoints;

    void Start()
    {
        health = GetComponent<SpawnMobController>().ChangeStatsMob(health);
        waypoints = GetComponent<WaypointsManager>().waypoints;
    }

    void Update()
    {
        Move(speed, waypoints);
    }
}
