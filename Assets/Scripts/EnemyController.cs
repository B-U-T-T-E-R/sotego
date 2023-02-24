using UnityEngine;
public class EnemyController : MonoBehaviour
{
    public int nextwayPoints = 1;
    public Transform[] wayPoints;
    private Rigidbody2D rb;
    private Collider2D col;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    public void Moving(float mspeed)
    {
        bool isCanRotate = GameObject.FindGameObjectWithTag("CanRotate").GetComponent<wayPointScript>().CanRotate;

        if (isCanRotate == true)
        {
            rb.velocity = Vector3.zero;
            nextwayPoints++;
        }

        Debug.Log(nextwayPoints);
            
        if (gameObject.transform.position.y > wayPoints[nextwayPoints].position.y)
            rb.velocity = new Vector2(0, -mspeed);
        else if(gameObject.transform.position.y < wayPoints[nextwayPoints].position.y)
            rb.velocity = new Vector2(0, mspeed);
        if (gameObject.transform.position.x > wayPoints[nextwayPoints].position.x)
            rb.velocity = new Vector2(-mspeed, 0);
        else if (gameObject.transform.position.x < wayPoints[nextwayPoints].position.x)
            rb.velocity = new Vector2(mspeed, 0);


    }

    void Die()
    {
        Destroy(gameObject);
    }
}