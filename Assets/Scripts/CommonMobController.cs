using UnityEngine;

public class CommonMobController : MonoBehaviour
{
    [SerializeField]
    private Transform spawn;

    [SerializeField]
    private GameObject mob;

    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform[] waypoints;

    [SerializeField]
    private int currentWaypoints;
    private int length;

    private GameObject newMob;

    void Start()
    {
        mob.transform.position = spawn.position;
        length = waypoints.Length;
    }
    void Update()
    {
        while(currentWaypoints != length)
        {
            if(transform.position.x == waypoints[currentWaypoints].position.x && transform.position.y > waypoints[currentWaypoints].position.y)
            {
                Down();
            }
            if(transform.position.x == waypoints[currentWaypoints].position.x && transform.position.y < waypoints[currentWaypoints].position.y)
            {
                Up();
            }
            if(transform.position.x > waypoints[currentWaypoints].position.x && transform.position.y == waypoints[currentWaypoints].position.y)
            {
                Right();
            }
            if(transform.position.x < waypoints[currentWaypoints].position.x && transform.position.y == waypoints[currentWaypoints].position.y)
            {
                Left();
            }

            if(transform.position == waypoints[currentWaypoints].position)
                currentWaypoints++;
        }
    }

    private void CreateMob()
    {
        newMob = Instantiate(mob);
        newMob.transform.position = spawn.position;
    }

    private void Up()
    {
        transform.Translate(0, speed, 0);
    }

    private void Down()
    {
        transform.Translate(0, -speed, 0);
    }

    private void Left()
    {
        transform.Translate(speed, 0, 0);
    }

    private void Right()
    {
        transform.Translate(-speed, 0, 0);
    }
}
