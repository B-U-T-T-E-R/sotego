using UnityEngine;
public class EnemyController : MonoBehaviour
{
    int nextwayPoints = 0;
    public Transform[] wayPoints;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Moving(float mspeed)
    {

        if (this.gameObject.transform.position == wayPoints[nextwayPoints].position)
            nextwayPoints++;

        if (this.gameObject.transform.position.y > wayPoints[nextwayPoints].position.y)
            rb.AddForce(new Vector2(0, -mspeed));
        else
            rb.AddForce(new Vector2(0, mspeed));
        if (this.gameObject.transform.position.x > wayPoints[nextwayPoints].position.x)
            rb.AddForce(new Vector2(-mspeed, 0));
        else
            rb.AddForce(new Vector2(mspeed, 0));
    }

    void Die()
    {
        Destroy(gameObject);
    }
}