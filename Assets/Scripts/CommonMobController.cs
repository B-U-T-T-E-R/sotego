using UnityEngine;

public class CommonMobController : EnemyController
{
    [SerializeField]
    private float speed = 50f;
    private Collider2D mob;
    [SerializeField]
    private GameObject tile;
    private bool CanMove = true;

    void Start()
    {
        mob = GetComponent<Collider2D>();
    }

    void Update()
    {
        tile = GameObject.FindWithTag("waypoint");
        if(CanMove == true)
        {
            Moving(speed);
            CanMove = false;
        }
        
        CanMove = tile.GetComponent<TileController>().OnTriggerEnter2D(mob);

        Debug.Log(CanMove == true);
    }
}