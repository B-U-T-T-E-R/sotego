using UnityEngine;
public class CommonMobController : EnemyController
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float health = 75;

    void Update()
    {
            Move();
    }
    
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "waypoint")
        {
            target += 1;
        }
        else if(collision.tag == "base")
        {
            Destroy(gameObject);
        }
    }
}