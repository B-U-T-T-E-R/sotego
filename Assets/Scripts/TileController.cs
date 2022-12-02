using UnityEngine;

public class TileController : MonoBehaviour
{
    public bool OnWaypoint;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
            OnWaypoint = true;
    }
}
