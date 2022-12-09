using UnityEngine;

public class TileController : MonoBehaviour
{
    public bool OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Entity")
            return true;
        return false;
    }
}
