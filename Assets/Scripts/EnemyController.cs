using UnityEngine;
using System.Collections.Generic;
public class EnemyController : MonoBehaviour
{
    public int target = 0;
    public Transform exit;
    public Transform[] wayPoints;
    public float navigation;
    private Vector3 pos;

    private bool isOnWaypoint;
    private float speed = 500;

    public Transform enemy;
    float navigationTime = 0;
    void Start()
    {
        enemy = GetComponent<Transform>();
    }

    public bool Move()
    {
        if(wayPoints != null)
        {
            navigationTime += Time.deltaTime;
            if(navigationTime > navigation)
            {
                if(target < wayPoints.Length)
                {
                    pos = Vector2.MoveTowards(this.gameObject.transform.position, wayPoints[target].position, navigationTime);
                }
                else
                {
                    pos = Vector2.MoveTowards(this.gameObject.transform.position, exit.position, navigationTime);
                }

                //transform.Translate(pos.x * speed, pos.y, pos.z);
            
                navigationTime = 0;
            }
            
            if(this.gameObject.transform.position == wayPoints[target].position)
            {
                target++;
                return true;
            }
        }

        return false;
    }
}
