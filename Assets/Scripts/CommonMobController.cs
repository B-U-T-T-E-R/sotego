using System;
using UnityEngine;
public class CommonMobController : EnemyController
{
    /*
    [SerializeField]
    private float speed;
    */
    [SerializeField]
    private float health = 75;

    public bool isOnWaypoint;

    void Update()
    {
        isOnWaypoint = GetComponent<TileController>().OnWaypoint;
        
        if(isOnWaypoint == true)
        {
            isOnWaypoint = Move();
        }
    }
}